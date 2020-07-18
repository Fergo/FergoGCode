namespace FergoGCode {
	partial class frmMain {
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.cmbProcess = new System.Windows.Forms.Button();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.txtLinearFeedCmd = new System.Windows.Forms.TextBox();
			this.txtFastFeedCmd = new System.Windows.Forms.TextBox();
			this.chkOrigin = new System.Windows.Forms.CheckBox();
			this.txtFooter = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHeader = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rdoRelative = new System.Windows.Forms.RadioButton();
			this.rdoAbsolute = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdoInches = new System.Windows.Forms.RadioButton();
			this.rdoMilimiters = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLinearFeed = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFastFeed = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpSingle = new System.Windows.Forms.GroupBox();
			this.txtLaserOn = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtLaserOff = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.grpMultiple = new System.Windows.Forms.GroupBox();
			this.rdoLaser = new System.Windows.Forms.RadioButton();
			this.rdoSpindle = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.nudPasses = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.lblPassN = new System.Windows.Forms.Label();
			this.lblPass1 = new System.Windows.Forms.Label();
			this.lblZHeight = new System.Windows.Forms.Label();
			this.nudZChange = new System.Windows.Forms.NumericUpDown();
			this.nudTravelHeight = new System.Windows.Forms.NumericUpDown();
			this.picTemplate = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtSpindleOn = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSpindleOff = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.nudPrecision = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbInput = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.grpOutput = new System.Windows.Forms.GroupBox();
			this.cboPrecision = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.chkComments = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cboProcess = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbOutput = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.cmbPreview = new System.Windows.Forms.Button();
			this.cmbSaveDXF = new System.Windows.Forms.Button();
			this.grpGeneral.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grpSingle.SuspendLayout();
			this.grpMultiple.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPasses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZChange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTravelHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTemplate)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecision)).BeginInit();
			this.grpOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbProcess
			// 
			this.cmbProcess.Location = new System.Drawing.Point(405, 593);
			this.cmbProcess.Name = "cmbProcess";
			this.cmbProcess.Size = new System.Drawing.Size(108, 30);
			this.cmbProcess.TabIndex = 0;
			this.cmbProcess.Text = "Generate G-Code";
			this.cmbProcess.UseVisualStyleBackColor = true;
			this.cmbProcess.Click += new System.EventHandler(this.cmbProcess_Click);
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.txtLinearFeedCmd);
			this.grpGeneral.Controls.Add(this.txtFastFeedCmd);
			this.grpGeneral.Controls.Add(this.chkOrigin);
			this.grpGeneral.Controls.Add(this.txtFooter);
			this.grpGeneral.Controls.Add(this.label6);
			this.grpGeneral.Controls.Add(this.txtHeader);
			this.grpGeneral.Controls.Add(this.label5);
			this.grpGeneral.Controls.Add(this.panel2);
			this.grpGeneral.Controls.Add(this.label4);
			this.grpGeneral.Controls.Add(this.panel1);
			this.grpGeneral.Controls.Add(this.label3);
			this.grpGeneral.Controls.Add(this.txtLinearFeed);
			this.grpGeneral.Controls.Add(this.label2);
			this.grpGeneral.Controls.Add(this.txtFastFeed);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Location = new System.Drawing.Point(13, 102);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(247, 394);
			this.grpGeneral.TabIndex = 1;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "General G-Code settings";
			// 
			// txtLinearFeedCmd
			// 
			this.txtLinearFeedCmd.Location = new System.Drawing.Point(120, 53);
			this.txtLinearFeedCmd.Name = "txtLinearFeedCmd";
			this.txtLinearFeedCmd.Size = new System.Drawing.Size(42, 20);
			this.txtLinearFeedCmd.TabIndex = 20;
			this.txtLinearFeedCmd.Text = "G1";
			// 
			// txtFastFeedCmd
			// 
			this.txtFastFeedCmd.Location = new System.Drawing.Point(120, 27);
			this.txtFastFeedCmd.Name = "txtFastFeedCmd";
			this.txtFastFeedCmd.Size = new System.Drawing.Size(42, 20);
			this.txtFastFeedCmd.TabIndex = 19;
			this.txtFastFeedCmd.Text = "G0";
			// 
			// chkOrigin
			// 
			this.chkOrigin.AutoSize = true;
			this.chkOrigin.Checked = true;
			this.chkOrigin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkOrigin.Location = new System.Drawing.Point(20, 364);
			this.chkOrigin.Name = "chkOrigin";
			this.chkOrigin.Size = new System.Drawing.Size(166, 17);
			this.chkOrigin.TabIndex = 14;
			this.chkOrigin.Text = "Return to origin when finished";
			this.chkOrigin.UseVisualStyleBackColor = true;
			// 
			// txtFooter
			// 
			this.txtFooter.Location = new System.Drawing.Point(20, 289);
			this.txtFooter.Multiline = true;
			this.txtFooter.Name = "txtFooter";
			this.txtFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFooter.Size = new System.Drawing.Size(209, 62);
			this.txtFooter.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Additional footer commands:";
			// 
			// txtHeader
			// 
			this.txtHeader.Location = new System.Drawing.Point(19, 207);
			this.txtHeader.Multiline = true;
			this.txtHeader.Name = "txtHeader";
			this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHeader.Size = new System.Drawing.Size(209, 63);
			this.txtHeader.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Additional header commands:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rdoRelative);
			this.panel2.Controls.Add(this.rdoAbsolute);
			this.panel2.Location = new System.Drawing.Point(19, 150);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(210, 29);
			this.panel2.TabIndex = 9;
			// 
			// rdoRelative
			// 
			this.rdoRelative.AutoSize = true;
			this.rdoRelative.Location = new System.Drawing.Point(101, 6);
			this.rdoRelative.Name = "rdoRelative";
			this.rdoRelative.Size = new System.Drawing.Size(93, 17);
			this.rdoRelative.TabIndex = 10;
			this.rdoRelative.Text = "Relative (G91)";
			this.rdoRelative.UseVisualStyleBackColor = true;
			// 
			// rdoAbsolute
			// 
			this.rdoAbsolute.AutoSize = true;
			this.rdoAbsolute.Checked = true;
			this.rdoAbsolute.Location = new System.Drawing.Point(0, 6);
			this.rdoAbsolute.Name = "rdoAbsolute";
			this.rdoAbsolute.Size = new System.Drawing.Size(95, 17);
			this.rdoAbsolute.TabIndex = 9;
			this.rdoAbsolute.TabStop = true;
			this.rdoAbsolute.Text = "Absolute (G90)";
			this.rdoAbsolute.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Positioning:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdoInches);
			this.panel1.Controls.Add(this.rdoMilimiters);
			this.panel1.Location = new System.Drawing.Point(19, 98);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 29);
			this.panel1.TabIndex = 7;
			// 
			// rdoInches
			// 
			this.rdoInches.AutoSize = true;
			this.rdoInches.Location = new System.Drawing.Point(101, 6);
			this.rdoInches.Name = "rdoInches";
			this.rdoInches.Size = new System.Drawing.Size(85, 17);
			this.rdoInches.TabIndex = 10;
			this.rdoInches.Text = "inches (G20)";
			this.rdoInches.UseVisualStyleBackColor = true;
			this.rdoInches.CheckedChanged += new System.EventHandler(this.Settings_ValueChanged);
			// 
			// rdoMilimiters
			// 
			this.rdoMilimiters.AutoSize = true;
			this.rdoMilimiters.Checked = true;
			this.rdoMilimiters.Location = new System.Drawing.Point(0, 6);
			this.rdoMilimiters.Name = "rdoMilimiters";
			this.rdoMilimiters.Size = new System.Drawing.Size(70, 17);
			this.rdoMilimiters.TabIndex = 9;
			this.rdoMilimiters.TabStop = true;
			this.rdoMilimiters.Text = "mm (G21)";
			this.rdoMilimiters.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Units:";
			// 
			// txtLinearFeed
			// 
			this.txtLinearFeed.Location = new System.Drawing.Point(164, 53);
			this.txtLinearFeed.Name = "txtLinearFeed";
			this.txtLinearFeed.Size = new System.Drawing.Size(64, 20);
			this.txtLinearFeed.TabIndex = 3;
			this.txtLinearFeed.Text = "750";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Linear feedrate:";
			// 
			// txtFastFeed
			// 
			this.txtFastFeed.Location = new System.Drawing.Point(164, 27);
			this.txtFastFeed.Name = "txtFastFeed";
			this.txtFastFeed.Size = new System.Drawing.Size(64, 20);
			this.txtFastFeed.TabIndex = 1;
			this.txtFastFeed.Text = "3000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fast feedrate:";
			// 
			// grpSingle
			// 
			this.grpSingle.Controls.Add(this.txtLaserOn);
			this.grpSingle.Controls.Add(this.label8);
			this.grpSingle.Controls.Add(this.txtLaserOff);
			this.grpSingle.Controls.Add(this.label7);
			this.grpSingle.Location = new System.Drawing.Point(266, 102);
			this.grpSingle.Name = "grpSingle";
			this.grpSingle.Size = new System.Drawing.Size(247, 89);
			this.grpSingle.TabIndex = 2;
			this.grpSingle.TabStop = false;
			this.grpSingle.Text = "Single pass";
			// 
			// txtLaserOn
			// 
			this.txtLaserOn.Location = new System.Drawing.Point(147, 53);
			this.txtLaserOn.Name = "txtLaserOn";
			this.txtLaserOn.Size = new System.Drawing.Size(82, 20);
			this.txtLaserOn.TabIndex = 5;
			this.txtLaserOn.Text = "M106 S170";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(17, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Laser on:";
			// 
			// txtLaserOff
			// 
			this.txtLaserOff.Location = new System.Drawing.Point(147, 27);
			this.txtLaserOff.Name = "txtLaserOff";
			this.txtLaserOff.Size = new System.Drawing.Size(82, 20);
			this.txtLaserOff.TabIndex = 3;
			this.txtLaserOff.Text = "M106 S10";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Laser off:";
			// 
			// grpMultiple
			// 
			this.grpMultiple.Controls.Add(this.rdoLaser);
			this.grpMultiple.Controls.Add(this.rdoSpindle);
			this.grpMultiple.Controls.Add(this.label13);
			this.grpMultiple.Controls.Add(this.nudPasses);
			this.grpMultiple.Controls.Add(this.label14);
			this.grpMultiple.Controls.Add(this.lblPassN);
			this.grpMultiple.Controls.Add(this.lblPass1);
			this.grpMultiple.Controls.Add(this.lblZHeight);
			this.grpMultiple.Controls.Add(this.nudZChange);
			this.grpMultiple.Controls.Add(this.nudTravelHeight);
			this.grpMultiple.Controls.Add(this.picTemplate);
			this.grpMultiple.Controls.Add(this.label20);
			this.grpMultiple.Controls.Add(this.txtSpindleOn);
			this.grpMultiple.Controls.Add(this.label11);
			this.grpMultiple.Controls.Add(this.txtSpindleOff);
			this.grpMultiple.Controls.Add(this.label12);
			this.grpMultiple.Location = new System.Drawing.Point(266, 197);
			this.grpMultiple.Name = "grpMultiple";
			this.grpMultiple.Size = new System.Drawing.Size(247, 299);
			this.grpMultiple.TabIndex = 14;
			this.grpMultiple.TabStop = false;
			this.grpMultiple.Text = "Multiple pass";
			// 
			// rdoLaser
			// 
			this.rdoLaser.AutoSize = true;
			this.rdoLaser.Location = new System.Drawing.Point(20, 181);
			this.rdoLaser.Name = "rdoLaser";
			this.rdoLaser.Size = new System.Drawing.Size(51, 17);
			this.rdoLaser.TabIndex = 26;
			this.rdoLaser.TabStop = true;
			this.rdoLaser.Text = "Laser";
			this.rdoLaser.UseVisualStyleBackColor = true;
			// 
			// rdoSpindle
			// 
			this.rdoSpindle.AutoSize = true;
			this.rdoSpindle.Location = new System.Drawing.Point(20, 158);
			this.rdoSpindle.Name = "rdoSpindle";
			this.rdoSpindle.Size = new System.Drawing.Size(60, 17);
			this.rdoSpindle.TabIndex = 25;
			this.rdoSpindle.TabStop = true;
			this.rdoSpindle.Text = "Spindle";
			this.rdoSpindle.UseVisualStyleBackColor = true;
			this.rdoSpindle.CheckedChanged += new System.EventHandler(this.Settings_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(17, 82);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(78, 13);
			this.label13.TabIndex = 24;
			this.label13.Text = "Z travel height:";
			// 
			// nudPasses
			// 
			this.nudPasses.Location = new System.Drawing.Point(147, 131);
			this.nudPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPasses.Name = "nudPasses";
			this.nudPasses.Size = new System.Drawing.Size(82, 20);
			this.nudPasses.TabIndex = 23;
			this.nudPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPasses.ValueChanged += new System.EventHandler(this.Settings_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(17, 134);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 13);
			this.label14.TabIndex = 22;
			this.label14.Text = "Passes:";
			// 
			// lblPassN
			// 
			this.lblPassN.ForeColor = System.Drawing.Color.Red;
			this.lblPassN.Location = new System.Drawing.Point(8, 256);
			this.lblPassN.Name = "lblPassN";
			this.lblPassN.Size = new System.Drawing.Size(138, 16);
			this.lblPassN.TabIndex = 21;
			this.lblPassN.Text = "Pass n: 1";
			this.lblPassN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPass1
			// 
			this.lblPass1.ForeColor = System.Drawing.Color.Red;
			this.lblPass1.Location = new System.Drawing.Point(5, 240);
			this.lblPass1.Name = "lblPass1";
			this.lblPass1.Size = new System.Drawing.Size(141, 16);
			this.lblPass1.TabIndex = 20;
			this.lblPass1.Text = "Pass 1: 1";
			this.lblPass1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblZHeight
			// 
			this.lblZHeight.ForeColor = System.Drawing.Color.Red;
			this.lblZHeight.Location = new System.Drawing.Point(2, 220);
			this.lblZHeight.Name = "lblZHeight";
			this.lblZHeight.Size = new System.Drawing.Size(144, 20);
			this.lblZHeight.TabIndex = 19;
			this.lblZHeight.Text = "Z Travel height: 7";
			this.lblZHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudZChange
			// 
			this.nudZChange.DecimalPlaces = 2;
			this.nudZChange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudZChange.Location = new System.Drawing.Point(147, 105);
			this.nudZChange.Name = "nudZChange";
			this.nudZChange.Size = new System.Drawing.Size(82, 20);
			this.nudZChange.TabIndex = 18;
			this.nudZChange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudZChange.ValueChanged += new System.EventHandler(this.Settings_ValueChanged);
			// 
			// nudTravelHeight
			// 
			this.nudTravelHeight.DecimalPlaces = 2;
			this.nudTravelHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudTravelHeight.Location = new System.Drawing.Point(147, 79);
			this.nudTravelHeight.Name = "nudTravelHeight";
			this.nudTravelHeight.Size = new System.Drawing.Size(82, 20);
			this.nudTravelHeight.TabIndex = 17;
			this.nudTravelHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudTravelHeight.ValueChanged += new System.EventHandler(this.Settings_ValueChanged);
			// 
			// picTemplate
			// 
			this.picTemplate.Image = global::FergoGCode.Properties.Resources.template_mill;
			this.picTemplate.Location = new System.Drawing.Point(147, 157);
			this.picTemplate.Name = "picTemplate";
			this.picTemplate.Size = new System.Drawing.Size(82, 136);
			this.picTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTemplate.TabIndex = 15;
			this.picTemplate.TabStop = false;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(17, 108);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(123, 13);
			this.label20.TabIndex = 16;
			this.label20.Text = "Z change on each pass:";
			// 
			// txtSpindleOn
			// 
			this.txtSpindleOn.Location = new System.Drawing.Point(147, 53);
			this.txtSpindleOn.Name = "txtSpindleOn";
			this.txtSpindleOn.Size = new System.Drawing.Size(82, 20);
			this.txtSpindleOn.TabIndex = 5;
			this.txtSpindleOn.Text = "M106 S170";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(17, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(87, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Spindle/laser on:";
			// 
			// txtSpindleOff
			// 
			this.txtSpindleOff.Location = new System.Drawing.Point(147, 27);
			this.txtSpindleOff.Name = "txtSpindleOff";
			this.txtSpindleOff.Size = new System.Drawing.Size(82, 20);
			this.txtSpindleOff.TabIndex = 3;
			this.txtSpindleOff.Text = "M106 S10";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(17, 30);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(87, 13);
			this.label12.TabIndex = 2;
			this.label12.Text = "Spindle/laser off:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.nudPrecision);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.cmbInput);
			this.groupBox4.Controls.Add(this.txtInput);
			this.groupBox4.Location = new System.Drawing.Point(13, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(500, 84);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Input file (Gerber or DXF)";
			// 
			// nudPrecision
			// 
			this.nudPrecision.Location = new System.Drawing.Point(107, 51);
			this.nudPrecision.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudPrecision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPrecision.Name = "nudPrecision";
			this.nudPrecision.Size = new System.Drawing.Size(50, 20);
			this.nudPrecision.TabIndex = 25;
			this.nudPrecision.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(17, 54);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(84, 13);
			this.label16.TabIndex = 24;
			this.label16.Text = "Spline precision:";
			// 
			// cmbInput
			// 
			this.cmbInput.Location = new System.Drawing.Point(448, 22);
			this.cmbInput.Name = "cmbInput";
			this.cmbInput.Size = new System.Drawing.Size(33, 22);
			this.cmbInput.TabIndex = 1;
			this.cmbInput.Tag = "";
			this.cmbInput.Text = "...";
			this.cmbInput.UseVisualStyleBackColor = true;
			this.cmbInput.Click += new System.EventHandler(this.cmbInput_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(18, 23);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(424, 20);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "C:\\Users\\fernando.birck\\Desktop\\GERBER\\Gerber_AP PCB Large_20190502100418\\Gerber_" +
    "TopPasteMaskLayer.GTP";
			// 
			// grpOutput
			// 
			this.grpOutput.Controls.Add(this.cboPrecision);
			this.grpOutput.Controls.Add(this.label15);
			this.grpOutput.Controls.Add(this.chkComments);
			this.grpOutput.Controls.Add(this.label10);
			this.grpOutput.Controls.Add(this.cboProcess);
			this.grpOutput.Controls.Add(this.label9);
			this.grpOutput.Controls.Add(this.cmbOutput);
			this.grpOutput.Controls.Add(this.txtOutput);
			this.grpOutput.Location = new System.Drawing.Point(14, 502);
			this.grpOutput.Name = "grpOutput";
			this.grpOutput.Size = new System.Drawing.Size(499, 85);
			this.grpOutput.TabIndex = 16;
			this.grpOutput.TabStop = false;
			this.grpOutput.Text = "G-Code output";
			// 
			// cboPrecision
			// 
			this.cboPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPrecision.FormattingEnabled = true;
			this.cboPrecision.Items.AddRange(new object[] {
            "0",
            "0.0",
            "0.00",
            "0.000",
            "0.0000",
            "0.00000",
            "0.000000",
            "0.0000000",
            "0.00000000",
            "0.000000000"});
			this.cboPrecision.Location = new System.Drawing.Point(279, 23);
			this.cboPrecision.Name = "cboPrecision";
			this.cboPrecision.Size = new System.Drawing.Size(113, 21);
			this.cboPrecision.TabIndex = 9;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(220, 26);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(53, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Precision:";
			// 
			// chkComments
			// 
			this.chkComments.AutoSize = true;
			this.chkComments.Location = new System.Drawing.Point(406, 25);
			this.chkComments.Name = "chkComments";
			this.chkComments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkComments.Size = new System.Drawing.Size(75, 17);
			this.chkComments.TabIndex = 7;
			this.chkComments.Text = "Comments";
			this.chkComments.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 53);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Output file:";
			// 
			// cboProcess
			// 
			this.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProcess.FormattingEnabled = true;
			this.cboProcess.Items.AddRange(new object[] {
            "Single pass",
            "Multiple pass"});
			this.cboProcess.Location = new System.Drawing.Point(92, 23);
			this.cboProcess.Name = "cboProcess";
			this.cboProcess.Size = new System.Drawing.Size(113, 21);
			this.cboProcess.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 26);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Process type:";
			// 
			// cmbOutput
			// 
			this.cmbOutput.Location = new System.Drawing.Point(448, 49);
			this.cmbOutput.Name = "cmbOutput";
			this.cmbOutput.Size = new System.Drawing.Size(33, 22);
			this.cmbOutput.TabIndex = 3;
			this.cmbOutput.Tag = "";
			this.cmbOutput.Text = "...";
			this.cmbOutput.UseVisualStyleBackColor = true;
			this.cmbOutput.Click += new System.EventHandler(this.cmbOutput_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(92, 50);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(353, 20);
			this.txtOutput.TabIndex = 2;
			this.txtOutput.Text = "C:\\Users\\fernando.birck\\Desktop\\GERBER\\Gerber_AP PCB Large_20190502100418\\Gerber_" +
    "TopPasteMaskLayer.gcode";
			// 
			// ofd
			// 
			this.ofd.Filter = "Todos os arquivos|*.*";
			// 
			// sfd
			// 
			this.sfd.FileName = "My GCode";
			this.sfd.Filter = "G-Code file (*.gcode)|*.gcode";
			// 
			// cmbPreview
			// 
			this.cmbPreview.Location = new System.Drawing.Point(291, 593);
			this.cmbPreview.Name = "cmbPreview";
			this.cmbPreview.Size = new System.Drawing.Size(108, 30);
			this.cmbPreview.TabIndex = 17;
			this.cmbPreview.Text = "Preview G-Code...";
			this.cmbPreview.UseVisualStyleBackColor = true;
			this.cmbPreview.Click += new System.EventHandler(this.cmbPreview_Click);
			// 
			// cmbSaveDXF
			// 
			this.cmbSaveDXF.Location = new System.Drawing.Point(14, 593);
			this.cmbSaveDXF.Name = "cmbSaveDXF";
			this.cmbSaveDXF.Size = new System.Drawing.Size(108, 30);
			this.cmbSaveDXF.TabIndex = 18;
			this.cmbSaveDXF.Text = "Export to DXF...";
			this.cmbSaveDXF.UseVisualStyleBackColor = true;
			this.cmbSaveDXF.Click += new System.EventHandler(this.cmbSaveDXF_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 628);
			this.Controls.Add(this.cmbSaveDXF);
			this.Controls.Add(this.cmbPreview);
			this.Controls.Add(this.grpOutput);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.grpMultiple);
			this.Controls.Add(this.grpSingle);
			this.Controls.Add(this.grpGeneral);
			this.Controls.Add(this.cmbProcess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "G-Code Processor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.grpSingle.ResumeLayout(false);
			this.grpSingle.PerformLayout();
			this.grpMultiple.ResumeLayout(false);
			this.grpMultiple.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPasses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZChange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTravelHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTemplate)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecision)).EndInit();
			this.grpOutput.ResumeLayout(false);
			this.grpOutput.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cmbProcess;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.TextBox txtLinearFeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFastFeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdoRelative;
		private System.Windows.Forms.RadioButton rdoAbsolute;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdoInches;
		private System.Windows.Forms.RadioButton rdoMilimiters;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFooter;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHeader;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox grpSingle;
		private System.Windows.Forms.TextBox txtLaserOn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtLaserOff;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox grpMultiple;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtSpindleOn;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSpindleOff;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox picTemplate;
		private System.Windows.Forms.NumericUpDown nudZChange;
		private System.Windows.Forms.NumericUpDown nudTravelHeight;
		private System.Windows.Forms.Label lblPassN;
		private System.Windows.Forms.Label lblPass1;
		private System.Windows.Forms.Label lblZHeight;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button cmbInput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.GroupBox grpOutput;
		private System.Windows.Forms.Button cmbOutput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboProcess;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Button cmbPreview;
		private System.Windows.Forms.NumericUpDown nudPasses;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chkComments;
		private System.Windows.Forms.ComboBox cboPrecision;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox chkOrigin;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RadioButton rdoLaser;
		private System.Windows.Forms.RadioButton rdoSpindle;
		private System.Windows.Forms.Button cmbSaveDXF;
		private System.Windows.Forms.TextBox txtLinearFeedCmd;
		private System.Windows.Forms.TextBox txtFastFeedCmd;
		private System.Windows.Forms.NumericUpDown nudPrecision;
		private System.Windows.Forms.Label label16;
	}
}

