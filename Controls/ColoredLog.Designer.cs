namespace FlameFTP.Controls {
	partial class ColoredLog {
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.LstLog = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// LstLog
			// 
			this.LstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.LstLog.DisplayMember = "Text";
			this.LstLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LstLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LstLog.ForeColor = System.Drawing.Color.White;
			this.LstLog.ItemHeight = 14;
			this.LstLog.Location = new System.Drawing.Point(0, 0);
			this.LstLog.Margin = new System.Windows.Forms.Padding(2);
			this.LstLog.Name = "LstLog";
			this.LstLog.Size = new System.Drawing.Size(672, 666);
			this.LstLog.TabIndex = 2;
			this.LstLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstLog_DrawItem);
			// 
			// ColoredLog
			// 
			this.Controls.Add(this.LstLog);
			this.Name = "ColoredLog";
			this.Size = new System.Drawing.Size(672, 666);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LstLog;
	}
}
