namespace FlameFTP.Controls {
	partial class FlameTab
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.SplitVert = new System.Windows.Forms.SplitContainer();
			this.SplitHoriz = new System.Windows.Forms.SplitContainer();
			this.LabelRemote = new System.Windows.Forms.Label();
			this.ExplorerLocal = new FlameFTP.Controls.LocalExplorer();
			this.ExplorerRemote = new FlameFTP.Controls.RemoteExplorer();
			this.LstLog = new FlameFTP.Controls.ColoredLog(this.components);
			((System.ComponentModel.ISupportInitialize)(this.SplitVert)).BeginInit();
			this.SplitVert.Panel1.SuspendLayout();
			this.SplitVert.Panel2.SuspendLayout();
			this.SplitVert.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitHoriz)).BeginInit();
			this.SplitHoriz.Panel1.SuspendLayout();
			this.SplitHoriz.Panel2.SuspendLayout();
			this.SplitHoriz.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitVert
			// 
			this.SplitVert.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitVert.Location = new System.Drawing.Point(0, 0);
			this.SplitVert.Name = "SplitVert";
			this.SplitVert.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitVert.Panel1
			// 
			this.SplitVert.Panel1.Controls.Add(this.SplitHoriz);
			// 
			// SplitVert.Panel2
			// 
			this.SplitVert.Panel2.Controls.Add(this.LstLog);
			this.SplitVert.Size = new System.Drawing.Size(979, 695);
			this.SplitVert.SplitterDistance = 496;
			this.SplitVert.TabIndex = 1;
			// 
			// SplitHoriz
			// 
			this.SplitHoriz.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitHoriz.Location = new System.Drawing.Point(0, 0);
			this.SplitHoriz.Name = "SplitHoriz";
			// 
			// SplitHoriz.Panel1
			// 
			this.SplitHoriz.Panel1.Controls.Add(this.ExplorerLocal);
			// 
			// SplitHoriz.Panel2
			// 
			this.SplitHoriz.Panel2.Controls.Add(this.LabelRemote);
			this.SplitHoriz.Panel2.Controls.Add(this.ExplorerRemote);
			this.SplitHoriz.Size = new System.Drawing.Size(979, 496);
			this.SplitHoriz.SplitterDistance = 492;
			this.SplitHoriz.TabIndex = 0;
			// 
			// LabelRemote
			// 
			this.LabelRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelRemote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LabelRemote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelRemote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.LabelRemote.Location = new System.Drawing.Point(0, 28);
			this.LabelRemote.Name = "LabelRemote";
			this.LabelRemote.Size = new System.Drawing.Size(483, 468);
			this.LabelRemote.TabIndex = 4;
			this.LabelRemote.Text = "?";
			this.LabelRemote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExplorerLocal
			// 
			this.ExplorerLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExplorerLocal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExplorerLocal.Location = new System.Drawing.Point(0, 0);
			this.ExplorerLocal.Margin = new System.Windows.Forms.Padding(2);
			this.ExplorerLocal.Name = "ExplorerLocal";
			this.ExplorerLocal.Size = new System.Drawing.Size(492, 496);
			this.ExplorerLocal.TabIndex = 2;
			// 
			// ExplorerRemote
			// 
			this.ExplorerRemote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExplorerRemote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExplorerRemote.Location = new System.Drawing.Point(0, 0);
			this.ExplorerRemote.Margin = new System.Windows.Forms.Padding(2);
			this.ExplorerRemote.Name = "ExplorerRemote";
			this.ExplorerRemote.Size = new System.Drawing.Size(483, 496);
			this.ExplorerRemote.TabIndex = 3;
			// 
			// LstLog
			// 
			this.LstLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LstLog.Location = new System.Drawing.Point(0, 0);
			this.LstLog.MaxItemCount = 500;
			this.LstLog.Name = "LstLog";
			this.LstLog.Size = new System.Drawing.Size(979, 195);
			this.LstLog.TabIndex = 4;
			// 
			// FlameTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SplitVert);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FlameTab";
			this.Size = new System.Drawing.Size(979, 695);
			this.SplitVert.Panel1.ResumeLayout(false);
			this.SplitVert.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitVert)).EndInit();
			this.SplitVert.ResumeLayout(false);
			this.SplitHoriz.Panel1.ResumeLayout(false);
			this.SplitHoriz.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitHoriz)).EndInit();
			this.SplitHoriz.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private LocalExplorer ExplorerLocal;
		private RemoteExplorer ExplorerRemote;
		private ColoredLog LstLog;
		private System.Windows.Forms.SplitContainer SplitVert;
		private System.Windows.Forms.SplitContainer SplitHoriz;
		private System.Windows.Forms.Label LabelRemote;
	}
}
