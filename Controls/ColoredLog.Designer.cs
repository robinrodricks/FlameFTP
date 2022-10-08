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
            this.components = new System.ComponentModel.Container();
            this.LstLog = new System.Windows.Forms.ListBox();
            this.cms_Log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_invertSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstLog
            // 
            this.LstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LstLog.ContextMenuStrip = this.cms_Log;
            this.LstLog.DisplayMember = "Text";
            this.LstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstLog.ForeColor = System.Drawing.Color.White;
            this.LstLog.ItemHeight = 14;
            this.LstLog.Location = new System.Drawing.Point(0, 0);
            this.LstLog.Margin = new System.Windows.Forms.Padding(2);
            this.LstLog.Name = "LstLog";
            this.LstLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstLog.Size = new System.Drawing.Size(672, 666);
            this.LstLog.TabIndex = 2;
            this.LstLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstLog_DrawItem);
            // 
            // cms_Log
            // 
            this.cms_Log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_selectAll,
            this.tsmi_invertSelection,
            this.toolStripSeparator1,
            this.tsmi_copy});
            this.cms_Log.Name = "cms_Log";
            this.cms_Log.Size = new System.Drawing.Size(181, 98);
            // 
            // tsmi_selectAll
            // 
            this.tsmi_selectAll.Name = "tsmi_selectAll";
            this.tsmi_selectAll.Size = new System.Drawing.Size(155, 22);
            this.tsmi_selectAll.Text = "Select All";
            this.tsmi_selectAll.Click += new System.EventHandler(this.tsmi_selectAll_Click);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(155, 22);
            this.tsmi_copy.Text = "Copy";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_invertSelection
            // 
            this.tsmi_invertSelection.Name = "tsmi_invertSelection";
            this.tsmi_invertSelection.Size = new System.Drawing.Size(180, 22);
            this.tsmi_invertSelection.Text = "Invert Selection";
            this.tsmi_invertSelection.Click += new System.EventHandler(this.tsmi_invertSelection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // ColoredLog
            // 
            this.Controls.Add(this.LstLog);
            this.Name = "ColoredLog";
            this.Size = new System.Drawing.Size(672, 666);
            this.cms_Log.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LstLog;
		private System.Windows.Forms.ContextMenuStrip cms_Log;
		private System.Windows.Forms.ToolStripMenuItem tsmi_selectAll;
		private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_invertSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
