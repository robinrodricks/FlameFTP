namespace FlameFTP.Controls {
	partial class ExplorerPanel
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
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.ExplorerLocal = new FlameFTP.Controls.LocalExplorer();
			this.ExplorerRemote = new FlameFTP.Controls.RemoteExplorer();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.listBox2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ExplorerLocal, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ExplorerRemote, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 741);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listBox2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.listBox2, 5);
			this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(3, 543);
			this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(1113, 196);
			this.listBox2.TabIndex = 1;
			// 
			// ExplorerLocal
			// 
			this.ExplorerLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExplorerLocal.Location = new System.Drawing.Point(3, 3);
			this.ExplorerLocal.Name = "ExplorerLocal";
			this.ExplorerLocal.Size = new System.Drawing.Size(543, 518);
			this.ExplorerLocal.TabIndex = 2;
			// 
			// ExplorerRemote
			// 
			this.ExplorerRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExplorerRemote.Location = new System.Drawing.Point(572, 3);
			this.ExplorerRemote.Name = "ExplorerRemote";
			this.ExplorerRemote.Size = new System.Drawing.Size(544, 518);
			this.ExplorerRemote.TabIndex = 3;
			// 
			// ExplorerPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ExplorerPanel";
			this.Size = new System.Drawing.Size(1119, 741);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox listBox2;
		private LocalExplorer ExplorerLocal;
		private RemoteExplorer ExplorerRemote;
	}
}
