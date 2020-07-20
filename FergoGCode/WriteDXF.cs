using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace FergoGCode {
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
