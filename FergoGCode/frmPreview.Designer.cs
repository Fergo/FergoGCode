namespace FergoGCode {
	partial class frmPreview {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtGCode = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtGCode
			// 
			this.txtGCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGCode.Location = new System.Drawing.Point(12, 12);
			this.txtGCode.Multiline = true;
			this.txtGCode.Name = "txtGCode";
			this.txtGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtGCode.Size = new System.Drawing.Size(610, 426);
			this.txtGCode.TabIndex = 0;
			// 
			// frmPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 450);
			this.Controls.Add(this.txtGCode);
			this.Name = "frmPreview";
			this.Text = "G-Code Preview";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtGCode;
	}
}