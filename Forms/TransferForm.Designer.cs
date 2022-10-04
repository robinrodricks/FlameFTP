namespace FlameFTP.Forms {
	partial class TransferForm {
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
			this.label10 = new System.Windows.Forms.Label();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.LabelType = new System.Windows.Forms.Label();
			this.LstFiles = new System.Windows.Forms.ListBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LabelCurFile = new System.Windows.Forms.Label();
			this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BarOverall = new System.Windows.Forms.ProgressBar();
			this.LabelTotalProgress = new System.Windows.Forms.Label();
			this.LabelFileProgress = new System.Windows.Forms.Label();
			this.BarFile = new System.Windows.Forms.ProgressBar();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(-1, -2);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(574, 37);
			this.label10.TabIndex = 22;
			this.label10.Text = "FILE TRANSFER";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// iconPictureBox2
			// 
			this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Upload;
			this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox2.IconSize = 26;
			this.iconPictureBox2.Location = new System.Drawing.Point(19, 51);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox2.TabIndex = 42;
			this.iconPictureBox2.TabStop = false;
			// 
			// LabelType
			// 
			this.LabelType.AutoSize = true;
			this.LabelType.Location = new System.Drawing.Point(45, 54);
			this.LabelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LabelType.Name = "LabelType";
			this.LabelType.Size = new System.Drawing.Size(86, 15);
			this.LabelType.TabIndex = 39;
			this.LabelType.Text = "Files To Upload";
			// 
			// LstFiles
			// 
			this.LstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LstFiles.IntegralHeight = false;
			this.LstFiles.ItemHeight = 15;
			this.LstFiles.Location = new System.Drawing.Point(147, 50);
			this.LstFiles.Margin = new System.Windows.Forms.Padding(2);
			this.LstFiles.Name = "LstFiles";
			this.LstFiles.ScrollAlwaysVisible = true;
			this.LstFiles.Size = new System.Drawing.Size(411, 103);
			this.LstFiles.TabIndex = 43;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
			this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox1.IconSize = 26;
			this.iconPictureBox1.Location = new System.Drawing.Point(16, 9);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox1.TabIndex = 45;
			this.iconPictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 15);
			this.label1.TabIndex = 44;
			this.label1.Text = "Current File";
			// 
			// iconPictureBox3
			// 
			this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Sync;
			this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox3.IconSize = 26;
			this.iconPictureBox3.Location = new System.Drawing.Point(16, 61);
			this.iconPictureBox3.Name = "iconPictureBox3";
			this.iconPictureBox3.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox3.TabIndex = 47;
			this.iconPictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 15);
			this.label2.TabIndex = 46;
			this.label2.Text = "Overall Progress";
			// 
			// LabelCurFile
			// 
			this.LabelCurFile.AutoSize = true;
			this.LabelCurFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCurFile.Location = new System.Drawing.Point(141, 12);
			this.LabelCurFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LabelCurFile.Name = "LabelCurFile";
			this.LabelCurFile.Size = new System.Drawing.Size(59, 15);
			this.LabelCurFile.TabIndex = 48;
			this.LabelCurFile.Text = "FileName";
			// 
			// iconPictureBox4
			// 
			this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Sync;
			this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox4.IconSize = 26;
			this.iconPictureBox4.Location = new System.Drawing.Point(16, 115);
			this.iconPictureBox4.Name = "iconPictureBox4";
			this.iconPictureBox4.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox4.TabIndex = 50;
			this.iconPictureBox4.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 118);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 15);
			this.label4.TabIndex = 49;
			this.label4.Text = "File Progress";
			// 
			// BarOverall
			// 
			this.BarOverall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BarOverall.Location = new System.Drawing.Point(144, 67);
			this.BarOverall.MarqueeAnimationSpeed = 10;
			this.BarOverall.Name = "BarOverall";
			this.BarOverall.Size = new System.Drawing.Size(402, 10);
			this.BarOverall.Step = 0;
			this.BarOverall.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.BarOverall.TabIndex = 51;
			this.BarOverall.Value = 50;
			// 
			// LabelTotalProgress
			// 
			this.LabelTotalProgress.AutoSize = true;
			this.LabelTotalProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTotalProgress.Location = new System.Drawing.Point(141, 80);
			this.LabelTotalProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LabelTotalProgress.Name = "LabelTotalProgress";
			this.LabelTotalProgress.Size = new System.Drawing.Size(26, 15);
			this.LabelTotalProgress.TabIndex = 52;
			this.LabelTotalProgress.Text = "1/1";
			// 
			// LabelFileProgress
			// 
			this.LabelFileProgress.AutoSize = true;
			this.LabelFileProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelFileProgress.Location = new System.Drawing.Point(141, 134);
			this.LabelFileProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LabelFileProgress.Name = "LabelFileProgress";
			this.LabelFileProgress.Size = new System.Drawing.Size(91, 15);
			this.LabelFileProgress.TabIndex = 54;
			this.LabelFileProgress.Text = "25 KB / 250 KB";
			// 
			// BarFile
			// 
			this.BarFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BarFile.Location = new System.Drawing.Point(144, 121);
			this.BarFile.MarqueeAnimationSpeed = 10;
			this.BarFile.Name = "BarFile";
			this.BarFile.Size = new System.Drawing.Size(402, 10);
			this.BarFile.Step = 0;
			this.BarFile.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.BarFile.TabIndex = 53;
			this.BarFile.Value = 50;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.LabelFileProgress);
			this.panel1.Controls.Add(this.BarFile);
			this.panel1.Controls.Add(this.LabelTotalProgress);
			this.panel1.Controls.Add(this.BarOverall);
			this.panel1.Controls.Add(this.iconPictureBox4);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.LabelCurFile);
			this.panel1.Controls.Add(this.iconPictureBox3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.iconPictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 164);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(569, 173);
			this.panel1.TabIndex = 55;
			// 
			// FrmTransfer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 341);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LstFiles);
			this.Controls.Add(this.iconPictureBox2);
			this.Controls.Add(this.LabelType);
			this.Controls.Add(this.label10);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FrmTransfer";
			this.Text = "File Transfer Status";
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
		private System.Windows.Forms.Label LabelType;
		private System.Windows.Forms.ListBox LstFiles;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LabelCurFile;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar BarOverall;
		private System.Windows.Forms.Label LabelTotalProgress;
		private System.Windows.Forms.Label LabelFileProgress;
		private System.Windows.Forms.ProgressBar BarFile;
		private System.Windows.Forms.Panel panel1;
	}
}