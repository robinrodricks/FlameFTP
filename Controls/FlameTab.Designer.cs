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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LstLog = new System.Windows.Forms.ListBox();
			this.ExplorerLocal = new FlameFTP.Controls.LocalExplorer();
			this.ExplorerRemote = new FlameFTP.Controls.RemoteExplorer();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.LstLog, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ExplorerLocal, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ExplorerRemote, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 695);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// LstLog
			// 
			this.LstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tableLayoutPanel1.SetColumnSpan(this.LstLog, 5);
			this.LstLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LstLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LstLog.ForeColor = System.Drawing.Color.White;
			this.LstLog.FormattingEnabled = true;
			this.LstLog.ItemHeight = 14;
			this.LstLog.Location = new System.Drawing.Point(2, 510);
			this.LstLog.Margin = new System.Windows.Forms.Padding(2);
			this.LstLog.Name = "LstLog";
			this.LstLog.Size = new System.Drawing.Size(975, 183);
			this.LstLog.TabIndex = 1;
			// 
			// ExplorerLocal
			// 
			this.ExplorerLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExplorerLocal.Location = new System.Drawing.Point(2, 2);
			this.ExplorerLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ExplorerLocal.Name = "ExplorerLocal";
			this.ExplorerLocal.Size = new System.Drawing.Size(481, 495);
			this.ExplorerLocal.TabIndex = 2;
			// 
			// ExplorerRemote
			// 
			this.ExplorerRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExplorerRemote.Location = new System.Drawing.Point(496, 2);
			this.ExplorerRemote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ExplorerRemote.Name = "ExplorerRemote";
			this.ExplorerRemote.Size = new System.Drawing.Size(481, 495);
			this.ExplorerRemote.TabIndex = 3;
			// 
			// FlameTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FlameTab";
			this.Size = new System.Drawing.Size(979, 695);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox LstLog;
		private LocalExplorer ExplorerLocal;
		private RemoteExplorer ExplorerRemote;
	}
}
