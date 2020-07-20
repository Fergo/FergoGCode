using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using GerberLibrary;
using GerberLibrary.Core;
using SimpleDXF;
using System.Threading;

namespace FergoGCode {
	public partial class frmMain : Form {

		private List<string> gerberExtensions = new List<string>(new string[] { ".GKO", ".GBL", ".GBP", ".GBO", ".GBS", ".DRL", ".GTL", ".GTP", ".GTO", ".GTS" });
		private List<Shape> shapes = null;

		private bool Process(bool Save) {
			if (shapes != null) {
				//Gets the parameters from the form
				GCodeSettings settings = ReadSettings();

				if (settings != null) {
					//Create the GCode string
					string gCode = GenerateGCode(shapes, settings);

					if (gCode.Length != 0) {
						if (Save) {
							try {
								File.WriteAllText(txtOutput.Text, gCode);
								MessageBox.Show("G-Code successfully generated", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
							} catch {
								MessageBox.Show("Failed to save the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						} else {
							frmPreview formPreview = new frmPreview();
							formPreview.txtGCode.Text = gCode;

							formPreview.ShowDialog();
						}
					} else {
						MessageBox.Show("Could not generate the G-Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				} else {
					MessageBox.Show("Invalid settings configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			} else {
				MessageBox.Show("No geometry found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private List<Shape> LoadDXF(string Path, int SplinePrecision, int CirclePrecision) {
			List<Shape> retShape = new List<Shape>();

			Document dxfFile = new Document(Path);
			dxfFile.Read();

			foreach (SimpleDXF.Line line in dxfFile.Lines) {
				Shape tempShape = new Shape();

				//Add start and end vertices
				tempShape.Vertices.Add(new Vector2d(line.P1.X, line.P1.Y));
				tempShape.Vertices.Add(new Vector2d(line.P2.X, line.P2.Y));

				retShape.Add(tempShape);
			}

			foreach (Polyline pl in dxfFile.Polylines) {
				Shape tempShape = new Shape();

				List<SimpleDXF.Vector2d> vertices = VertexConverter.GetPolyVertexes(pl, SplinePrecision);

				//Add all vertices of the shape
				foreach (SimpleDXF.Vector2d point in vertices)
					tempShape.Vertices.Add(new Vector2d(point.X, point.Y));

				//If it's closed, add the first vertex at the end (so we are back where we started)
				if (pl.Closed)
					tempShape.Vertices.Add(new Vector2d(vertices[0].X, vertices[0].Y));

				retShape.Add(tempShape);
			}

			foreach (Circle circle in dxfFile.Circles) {
				Shape tempShape = new Shape();

				List<SimpleDXF.Vector2d> vertices = VertexConverter.GetCircleVertexes(circle, CirclePrecision);

				foreach (SimpleDXF.Vector2d point in vertices)
					tempShape.Vertices.Add(new Vector2d(point.X, point.Y));

				//Repeat first vertex to close the circle
				tempShape.Vertices.Add(new Vector2d(vertices[0].X, vertices[0].Y));

				retShape.Add(tempShape);
			}

			foreach (Arc arc in dxfFile.Arcs) {
				Shape tempShape = new Shape();

				List<SimpleDXF.Vector2d> vertices = VertexConverter.GetArcVertexes(arc, SplinePrecision);

				foreach (SimpleDXF.Vector2d point in vertices)
					tempShape.Vertices.Add(new Vector2d(point.X, point.Y));

				retShape.Add(tempShape);
			}

			if (retShape.Count > 0)
				return retShape;
			else
				return null;

		}

		private List<Shape> LoadGerber(string Path) {
			BoardFileType FileType = Gerber.FindFileType(Path);

			if (FileType == BoardFileType.Unsupported)
				return null;

			ParsedGerber PLS;
			GerberParserState State = new GerberParserState() { PreCombinePolygons = false };

			if (FileType == BoardFileType.Drill) {
				PLS = PolyLineSet.LoadExcellonDrillFile(Path, false, 1.0);
			} else {
				bool forcezerowidth = false;
				bool precombinepolygons = false;

				BoardSide Side = BoardSide.Unknown;
				BoardLayer Layer = BoardLayer.Unknown;
				Gerber.DetermineBoardSideAndLayer(Path, out Side, out Layer);

				if (Layer == BoardLayer.Outline || Layer == BoardLayer.Mill) {
					forcezerowidth = true;
					precombinepolygons = true;
				}
				State.PreCombinePolygons = precombinepolygons;

				PLS = PolyLineSet.LoadGerberFile(Path, forcezerowidth, false, State);
				PLS.Side = State.Side;
				PLS.Layer = State.Layer;

				if (Layer == BoardLayer.Outline)
					PLS.FixPolygonWindings();
			}

			//Convert the gerber polygons into a generic shape list used by other functions
			List<Shape> retShape = new List<Shape>();
			foreach (var shape in PLS.DisplayShapes) {
				Shape tempShape = new Shape();

				tempShape.Vertices = new List<Vector2d>();

				for (int i = 0; i < shape.Vertices.Count; i++)
					tempShape.Vertices.Add(new Vector2d(shape.Vertices[i].X, shape.Vertices[i].Y));

				retShape.Add(tempShape);
			}

			return retShape;
		}

		private void SaveAppSettings(string Path) {
			StreamWriter sw = new StreamWriter(Path);

			sw.WriteLine(txtInput.Text);
			sw.WriteLine(txtOutput.Text);
			sw.WriteLine(cboProcess.SelectedIndex);
			sw.WriteLine(cboPrecision.SelectedIndex);
			sw.WriteLine(chkComments.Checked);
			sw.WriteLine(txtLaserOn.Text);
			sw.WriteLine(txtLaserOff.Text);
			sw.WriteLine(txtSpindleOn.Text);
			sw.WriteLine(txtSpindleOff.Text);
			sw.WriteLine(rdoMilimiters.Checked);
			sw.WriteLine(rdoAbsolute.Checked);
			sw.WriteLine(txtHeader.Text);
			sw.WriteLine(txtFooter.Text);
			sw.WriteLine(nudTravelHeight.Value);
			sw.WriteLine(nudZChange.Value);
			sw.WriteLine(nudPasses.Value);
			sw.WriteLine(txtFastFeed.Text);
			sw.WriteLine(txtLinearFeed.Text);
			sw.WriteLine(chkOrigin.Checked);
			sw.WriteLine(rdoSpindle.Checked);
			sw.WriteLine(txtFastFeedCmd.Text);
			sw.WriteLine(txtLinearFeedCmd.Text);
			sw.WriteLine(nudSplinePrecision.Value);
			sw.WriteLine(nudCirclePrecision.Value);

			sw.Close();
		}

		private bool LoadAppSettings(string Path) {
			bool error = true;

			if (File.Exists(Path)) {
				StreamReader sr = new StreamReader(Path);

				try {
					txtInput.Text = sr.ReadLine();
					txtOutput.Text = sr.ReadLine();
					cboProcess.SelectedIndex = Convert.ToInt32(sr.ReadLine());
					cboPrecision.SelectedIndex = Convert.ToInt32(sr.ReadLine());
					chkComments.Checked = Convert.ToBoolean(sr.ReadLine());
					txtLaserOn.Text = sr.ReadLine();
					txtLaserOff.Text = sr.ReadLine();
					txtSpindleOn.Text = sr.ReadLine();
					txtSpindleOff.Text = sr.ReadLine();
					rdoMilimiters.Checked = Convert.ToBoolean(sr.ReadLine());
					rdoInches.Checked = !rdoMilimiters.Checked;
					rdoAbsolute.Checked = Convert.ToBoolean(sr.ReadLine());
					rdoRelative.Checked = !rdoAbsolute.Checked;
					txtHeader.Text = sr.ReadLine();
					txtFooter.Text = sr.ReadLine();
					nudTravelHeight.Value = Convert.ToDecimal(sr.ReadLine());
					nudZChange.Value = Convert.ToDecimal(sr.ReadLine());
					nudPasses.Value = Convert.ToDecimal(sr.ReadLine());
					txtFastFeed.Text = sr.ReadLine();
					txtLinearFeed.Text = sr.ReadLine();
					chkOrigin.Checked = Convert.ToBoolean(sr.ReadLine());
					rdoSpindle.Checked = Convert.ToBoolean(sr.ReadLine());
					rdoLaser.Checked = !rdoSpindle.Checked;
					txtFastFeedCmd.Text = sr.ReadLine();
					txtLinearFeedCmd.Text = sr.ReadLine();
					nudSplinePrecision.Value = Convert.ToDecimal(sr.ReadLine());
					nudCirclePrecision.Value = Convert.ToDecimal(sr.ReadLine());

					error = false;
				} catch {
					MessageBox.Show("Unable to load all program settings", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} finally {
					sr.Close();
				}
			}

			return !error;
		}

		private GCodeSettings ReadSettings() {
			GCodeSettings settings = new GCodeSettings();

			settings.gcLaserOn = txtLaserOn.Text;
			settings.gcLaserOff = txtLaserOff.Text;

			settings.gcSpindleOn = txtSpindleOn.Text;
			settings.gcSpindleOff = txtSpindleOff.Text;

			settings.gcUnit = rdoMilimiters.Checked ? "G21" : "G20";
			settings.gcPositioning = rdoAbsolute.Checked ? "G90" : "G91";

			settings.gcHeader = txtHeader.Text;
			settings.gcFooter = txtFooter.Text;

			settings.gcZTravelHeight = (double)nudTravelHeight.Value;
			settings.gcZChange = (double)nudZChange.Value;
			settings.gcPass = (int)nudPasses.Value;
			settings.gcRapidRaise = true;

			if (!int.TryParse(txtFastFeed.Text, out settings.gcMoveFeed)) {
				MessageBox.Show("Invalid fast feed value", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			if (!int.TryParse(txtLinearFeed.Text, out settings.gcLinearFeed)) {
				MessageBox.Show("Invalid linear feed value", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			settings.gcMoveFeedCmd = txtFastFeedCmd.Text;
			settings.gcLinearFeedCmd = txtLinearFeedCmd.Text;

			settings.gcComments = chkComments.Checked;
			settings.gcType = cboProcess.SelectedIndex == 0 ? GCodeType.SINGLE_PASS : GCodeType.MULTIPLE_PASS;
			settings.gcPrecisionFormat = cboPrecision.Text;
			settings.gcReturnOrigin = chkOrigin.Checked;
			settings.gcIsSpindle = rdoSpindle.Checked;

			return settings;
		}

		private string GenerateGCode(List<Shape> Shapes, GCodeSettings Settings) {
			StringBuilder sb = new StringBuilder();
			int shapeCount;

			if (Settings.gcHeader != "")
				sb.AppendLine(Settings.gcHeader);

			sb.AppendLine(Settings.gcUnit);
			sb.AppendLine(Settings.gcPositioning);

			if (Settings.gcType == GCodeType.SINGLE_PASS) {
				//SINGLE PASS (for laser engraving or cutting thing surfaces)

				shapeCount = 1;

				foreach (Shape shape in Shapes) {
					if (Settings.gcComments)
						sb.AppendLine("; Shape " + shapeCount);

					//Turn the laser off
					sb.AppendLine(Settings.gcLaserOff);

					//Dwell for 100ms
					sb.AppendLine("G4 P100"); 

					//Fast move to the shape's start position
					sb.AppendLine(Settings.gcMoveFeedCmd +
									" X" + shape.Vertices[0].X.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
									" Y" + shape.Vertices[0].Y.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
									" F" + Settings.gcMoveFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

					//Wait for moves to finish
					sb.AppendLine("M400");

					//Turn the laser on
					sb.AppendLine(Settings.gcLaserOn);

					//Dwell for 100ms
					sb.AppendLine("G4 P100"); 

					//Linear move with slower feedrate (where the actual engraving occurs)
					foreach (Vector2d point in shape.Vertices)
						sb.AppendLine(Settings.gcLinearFeedCmd +
										" X" + point.X.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
										" Y" + point.Y.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
										" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

					//Wait for moves to finish
					sb.AppendLine("M400"); 

					shapeCount++;
				}

				//Turn the laser off
				sb.AppendLine(Settings.gcLaserOff);

				sb.AppendLine("G4 P100"); //Dwell for 100ms 
			} else {
				//MULTI-PASS MODE (for milling or laser cutting that involves multiple passes with different heights)

				double currentDepth;

				if (Settings.gcIsSpindle)
					currentDepth = -Settings.gcZChange;
				else
					currentDepth = 0;

				//If using spindle motor, make sure we raise the spindle before turning it on
				if (Settings.gcIsSpindle) {
					sb.AppendLine(Settings.gcMoveFeedCmd +
									" Z" + Settings.gcZTravelHeight.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
									" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

					sb.AppendLine("M400");

					sb.AppendLine(Settings.gcSpindleOn);

					sb.AppendLine("G4 P100");
				} else {
					sb.AppendLine(Settings.gcSpindleOff);

					sb.AppendLine("G4 P100");
				}

				for (int a = 0; a < Settings.gcPass; a++) {
					shapeCount = 1;

					if (Settings.gcComments)
						sb.AppendLine("; \r\n; PASS " + (a + 1) + "\r\n; ");

					//If using laser, we only move the Z axis every pass (the spindle needs to move the Z axis every shape) in relative space
					if (!Settings.gcIsSpindle) {
						sb.AppendLine("G91");

						sb.AppendLine(Settings.gcLinearFeedCmd +
										" Z" + currentDepth.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
										" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

						sb.AppendLine("M400");

						//Restore the original positioning mode (relative/absolute)
						sb.AppendLine(Settings.gcPositioning);
					}

					foreach (Shape shape in Shapes) {
						if (Settings.gcComments)
							sb.AppendLine("; Shape " + shapeCount);

						//Fast move to initial shape coordinate
						sb.AppendLine(Settings.gcMoveFeedCmd +
										" X" + shape.Vertices[0].X.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
										" Y" + shape.Vertices[0].Y.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
										" F" + Settings.gcMoveFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

						sb.AppendLine("M400");

						if (Settings.gcIsSpindle) {
							//If using spindle, lower it to the current pass depth
							sb.AppendLine(Settings.gcLinearFeedCmd +
											" Z" + currentDepth.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
											" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

							sb.AppendLine("M400");
						} else {
							//Otherwise turn the layer on
							sb.AppendLine(Settings.gcSpindleOn);

							sb.AppendLine("G4 P100");
						}

						//Linear move to start milling/laser cutting
						foreach (Vector2d point in shape.Vertices)
							sb.AppendLine(Settings.gcLinearFeedCmd +
											" X" + point.X.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
											" Y" + point.Y.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
											" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

						sb.AppendLine("M400");

						if (Settings.gcIsSpindle) {
							//If using spindle, raised it to the travel height
							sb.AppendLine(Settings.gcLinearFeedCmd +
											" Z" + Settings.gcZTravelHeight.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture) +
											" F" + Settings.gcLinearFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

							sb.AppendLine("M400");
						} else {
							//Otherwise turn the layer off to move into the next shape
							sb.AppendLine(Settings.gcSpindleOff);

							sb.AppendLine("G4 P100");
						}

						shapeCount++;
					}

					//Go deeper for the next pass
					currentDepth = -Settings.gcZChange;
				}

				//Make sure we end with the spindle off
				sb.AppendLine(Settings.gcSpindleOff);

				sb.AppendLine("G4 P100");
			}

			//Return to origin
			if (Settings.gcReturnOrigin)
				sb.AppendLine("G0 X0 Y0 F" + Settings.gcMoveFeed.ToString(Settings.gcPrecisionFormat, CultureInfo.InvariantCulture));

			if (Settings.gcFooter != "")
				sb.AppendLine(Settings.gcFooter);

			return sb.ToString();
		}

		private void UpdateVisualization() {
			string unit = rdoMilimiters.Checked ? "mm" : "in";

			lblZHeight.Text = string.Format("Z Travel height: {0:0.00} {1}", nudTravelHeight.Value, unit);
			lblPass1.Text = string.Format("Pass 1: {0:0.00} {1}", rdoSpindle.Checked == true ? nudZChange.Value : 0, unit);

			if (nudPasses.Value > 1) {
				lblPassN.Text = string.Format("Pass {0}: {1:0.00} {2}", nudPasses.Value, nudZChange.Value * (nudPasses.Value - (rdoSpindle.Checked == true ? 0 : 1)), unit);
				lblPassN.Visible = true;
			} else {
				lblPassN.Visible = false;
			}

			if (rdoLaser.Checked) {
				nudTravelHeight.Enabled = false;
				picTemplate.Image = Properties.Resources.template_laser;
			} else {
				nudTravelHeight.Enabled = true;
				picTemplate.Image = Properties.Resources.template_mill;
			}

		}

		private void EnableButtons(bool Enable) {
			cmbSaveDXF.Enabled = Enable;
			cmbProcess.Enabled = Enable;
			cmbPreview.Enabled = Enable;

			grpGeneral.Enabled = Enable;
			grpSingle.Enabled = Enable;
			grpMultiple.Enabled = Enable;
			grpOutput.Enabled = Enable;
		}

		private void OpenFile(string Filename) {
			if (Path.GetExtension(Filename).ToUpper() == ".DXF") {
				shapes = LoadDXF(Filename, (int)nudSplinePrecision.Value, (int)nudCirclePrecision.Value);
			} else if (gerberExtensions.Contains(Path.GetExtension(Filename).ToUpper())) {
				shapes = LoadGerber(Filename);
			} else {
				MessageBox.Show("Invalid input file. Please select a DXF or a Gerber layer file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				shapes = null;
			}

			//If we actually loaded something, enable the UI
			if (shapes != null)
				EnableButtons(true);
			else
				EnableButtons(false);
		}

		public frmMain() {
			InitializeComponent();

			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		}

		private void cmbPreview_Click(object sender, EventArgs e) {
			Process(false);
		}

		private void cmbProcess_Click(object sender, EventArgs e) {
			Process(true);
		}

		private void Settings_ValueChanged(object sender, EventArgs e) {
			UpdateVisualization();
		}

		private void frmMain_Load(object sender, EventArgs e) {
			EnableButtons(false);

			if (!LoadAppSettings(Path.Combine(Application.StartupPath, "settings.cfg"))) {
				cboProcess.SelectedIndex = 0;
				cboPrecision.SelectedIndex = 4;
			}

			UpdateVisualization();
		}

		private void cmbInput_Click(object sender, EventArgs e) {
			ofd.Filter = "All files|*.*";

			if (ofd.ShowDialog() == DialogResult.OK) {
				if (File.Exists(ofd.FileName)) {
					OpenFile(ofd.FileName);
					txtInput.Text = ofd.FileName;
				} else {
					MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void cmbOutput_Click(object sender, EventArgs e) {
			sfd.Filter = "G-Code file (*.gcode)|*.gcode";

			if (sfd.ShowDialog() == DialogResult.OK) {
				txtOutput.Text = sfd.FileName;
			}
		}

		private void cmbSaveDXF_Click(object sender, EventArgs e) {
			sfd.Filter = "DXF files (*.dxf)|*.dxf";

			if (sfd.ShowDialog() == DialogResult.OK) {
				if (WriteDXF.CreateDXF(sfd.FileName, shapes, 3)) {
					MessageBox.Show("DXF successfully exported", "DXF Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("Error exporting DXF file. Make sure the target file is not opened somewhere else.", "DXF Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			SaveAppSettings(Path.Combine(Application.StartupPath, "settings.cfg"));
		}
	}

	public enum GCodeType {
		SINGLE_PASS,
		MULTIPLE_PASS
	}

	public class Shape {
		public List<Vector2d> Vertices;

		public Shape() {
			this.Vertices = new List<Vector2d>();
		}

		public Shape(List<Vector2d> Vertices) {
			this.Vertices = Vertices;
		}
	}

	public class Vector2d {
		public double X;
		public double Y;

		public Vector2d(double X, double Y) {
			this.X = X;
			this.Y = Y;
		}
	}

	public class GCodeSettings {
		public string gcLaserOn;
		public string gcLaserOff;

		public string gcSpindleOn;
		public string gcSpindleOff;

		public string gcUnit;
		public string gcPositioning;

		public string gcHeader;
		public string gcFooter;

		public double gcZTravelHeight;
		public double gcZChange;
		public int gcPass;
		public bool gcRapidRaise;

		public int gcMoveFeed;
		public int gcLinearFeed;

		public string gcMoveFeedCmd;
		public string gcLinearFeedCmd;

		public GCodeType gcType;
		public string gcPrecisionFormat;
		public bool gcComments;
		public bool gcReturnOrigin;
		public bool gcIsSpindle;
	}

	public static class WriteDXF {
		public static bool CreateDXF(string Path, List<Shape> Polygons, int Color) {
			try {
				StreamWriter sw = new StreamWriter(Path);

				sw.WriteLine("0");
				sw.WriteLine("SECTION");
				sw.WriteLine("2");
				sw.WriteLine("ENTITIES");

				foreach (Shape shape in Polygons) {
					sw.WriteLine("0");
					sw.WriteLine("POLYLINE");
					sw.WriteLine("8");          //LAYER
					sw.WriteLine("0");          //Layer Name
					sw.WriteLine("66");         //ENTITIES FOLLOW
					sw.WriteLine("1");          //Yes
					sw.WriteLine("62");         //COLOR
					sw.WriteLine(Color);        //Color code
					sw.WriteLine("10");         //X
					sw.WriteLine("0.0");        //X Coord
					sw.WriteLine("20");         //Y
					sw.WriteLine("0.0");        //Y Coord
					sw.WriteLine("30");         //Z
					sw.WriteLine("0.0");        //Z Coord

					foreach (Vector2d points in shape.Vertices) {
						sw.WriteLine("0");
						sw.WriteLine("VERTEX");
						sw.WriteLine("8");
						sw.WriteLine("0");

						sw.WriteLine("10");
						sw.WriteLine(points.X.ToString(NumberFormatInfo.InvariantInfo));
						sw.WriteLine("20");
						sw.WriteLine(points.Y.ToString(NumberFormatInfo.InvariantInfo));
						sw.WriteLine("30");
						sw.WriteLine("0.0");
					}

					sw.WriteLine("0");
					sw.WriteLine("SEQEND");
				}

				sw.WriteLine("0");
				sw.WriteLine("ENDSEC");
				sw.WriteLine("0");
				sw.WriteLine("EOF");
				sw.WriteLine("");

				sw.Close();

				return true;
			} catch {
				return false;
			}
		}
	}
}
