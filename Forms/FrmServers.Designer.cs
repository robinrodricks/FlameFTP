namespace FlameFTP.Forms {
	partial class FrmServers
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.CbDataConn = new System.Windows.Forms.ComboBox();
			this.CbSecureProtocol = new System.Windows.Forms.ComboBox();
			this.CbProtocol = new System.Windows.Forms.ComboBox();
			this.TxtDisplayName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnSave = new System.Windows.Forms.Button();
			this.LstServers = new System.Windows.Forms.ListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.NumPort = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtHost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CbAuto = new System.Windows.Forms.CheckBox();
			this.GrpManual = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnNew = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CbEncoding = new System.Windows.Forms.ComboBox();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.TxtPass = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.PanelProfile = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.CbDataTrans = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
			this.GrpManual.SuspendLayout();
			this.PanelProfile.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 148);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 15);
			this.label9.TabIndex = 20;
			this.label9.Text = "Data Connection Type";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 40);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "Protocol";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 67);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "Secure Protocol";
			// 
			// CbDataConn
			// 
			this.CbDataConn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDataConn.Location = new System.Drawing.Point(165, 144);
			this.CbDataConn.Margin = new System.Windows.Forms.Padding(2);
			this.CbDataConn.Name = "CbDataConn";
			this.CbDataConn.Size = new System.Drawing.Size(168, 23);
			this.CbDataConn.TabIndex = 17;
			// 
			// CbSecureProtocol
			// 
			this.CbSecureProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbSecureProtocol.Location = new System.Drawing.Point(165, 63);
			this.CbSecureProtocol.Margin = new System.Windows.Forms.Padding(2);
			this.CbSecureProtocol.Name = "CbSecureProtocol";
			this.CbSecureProtocol.Size = new System.Drawing.Size(168, 23);
			this.CbSecureProtocol.TabIndex = 16;
			// 
			// CbProtocol
			// 
			this.CbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbProtocol.Location = new System.Drawing.Point(165, 36);
			this.CbProtocol.Margin = new System.Windows.Forms.Padding(2);
			this.CbProtocol.Name = "CbProtocol";
			this.CbProtocol.Size = new System.Drawing.Size(168, 23);
			this.CbProtocol.TabIndex = 15;
			// 
			// TxtDisplayName
			// 
			this.TxtDisplayName.Location = new System.Drawing.Point(116, 13);
			this.TxtDisplayName.Margin = new System.Windows.Forms.Padding(2);
			this.TxtDisplayName.MaxLength = 1000;
			this.TxtDisplayName.Name = "TxtDisplayName";
			this.TxtDisplayName.Size = new System.Drawing.Size(240, 23);
			this.TxtDisplayName.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 16);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Display Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 212);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Port";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 70);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Host Name";
			// 
			// BtnSave
			// 
			this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnSave.Location = new System.Drawing.Point(115, 531);
			this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(100, 25);
			this.BtnSave.TabIndex = 3;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// LstServers
			// 
			this.LstServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LstServers.FormattingEnabled = true;
			this.LstServers.IntegralHeight = false;
			this.LstServers.ItemHeight = 15;
			this.LstServers.Location = new System.Drawing.Point(11, 48);
			this.LstServers.Margin = new System.Windows.Forms.Padding(2);
			this.LstServers.Name = "LstServers";
			this.LstServers.ScrollAlwaysVisible = true;
			this.LstServers.Size = new System.Drawing.Size(309, 479);
			this.LstServers.TabIndex = 0;
			this.LstServers.SelectedIndexChanged += new System.EventHandler(this.LstServers_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(729, 37);
			this.label10.TabIndex = 21;
			this.label10.Text = "SERVERS";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumPort
			// 
			this.NumPort.Location = new System.Drawing.Point(116, 205);
			this.NumPort.Name = "NumPort";
			this.NumPort.Size = new System.Drawing.Size(120, 23);
			this.NumPort.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label11.Location = new System.Drawing.Point(115, 39);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(250, 15);
			this.label11.TabIndex = 23;
			this.label11.Text = "Any name you would remember this server by";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(115, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 15);
			this.label2.TabIndex = 25;
			this.label2.Text = "The server\'s domain or IP address";
			// 
			// TxtHost
			// 
			this.TxtHost.Location = new System.Drawing.Point(116, 66);
			this.TxtHost.Margin = new System.Windows.Forms.Padding(2);
			this.TxtHost.MaxLength = 1000;
			this.TxtHost.Name = "TxtHost";
			this.TxtHost.Size = new System.Drawing.Size(240, 23);
			this.TxtHost.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(115, 231);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 15);
			this.label3.TabIndex = 26;
			this.label3.Text = "Which port to connect to (use 0 for automatic)";
			// 
			// CbAuto
			// 
			this.CbAuto.AutoSize = true;
			this.CbAuto.Location = new System.Drawing.Point(116, 267);
			this.CbAuto.Name = "CbAuto";
			this.CbAuto.Size = new System.Drawing.Size(100, 19);
			this.CbAuto.TabIndex = 27;
			this.CbAuto.Text = "Auto Connect";
			this.CbAuto.UseVisualStyleBackColor = true;
			this.CbAuto.CheckedChanged += new System.EventHandler(this.CbAuto_CheckedChanged);
			// 
			// GrpManual
			// 
			this.GrpManual.Controls.Add(this.label16);
			this.GrpManual.Controls.Add(this.CbDataTrans);
			this.GrpManual.Controls.Add(this.label1);
			this.GrpManual.Controls.Add(this.CbEncoding);
			this.GrpManual.Controls.Add(this.label9);
			this.GrpManual.Controls.Add(this.label8);
			this.GrpManual.Controls.Add(this.label7);
			this.GrpManual.Controls.Add(this.CbDataConn);
			this.GrpManual.Controls.Add(this.CbSecureProtocol);
			this.GrpManual.Controls.Add(this.CbProtocol);
			this.GrpManual.Location = new System.Drawing.Point(19, 309);
			this.GrpManual.Name = "GrpManual";
			this.GrpManual.Size = new System.Drawing.Size(360, 190);
			this.GrpManual.TabIndex = 28;
			this.GrpManual.TabStop = false;
			this.GrpManual.Text = "Manual Connection Settings";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(20, 267);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 15);
			this.label12.TabIndex = 29;
			this.label12.Text = "Method";
			// 
			// BtnDelete
			// 
			this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnDelete.Location = new System.Drawing.Point(219, 531);
			this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(100, 25);
			this.BtnDelete.TabIndex = 30;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnNew
			// 
			this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnNew.Location = new System.Drawing.Point(11, 531);
			this.BtnNew.Margin = new System.Windows.Forms.Padding(2);
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.Size = new System.Drawing.Size(100, 25);
			this.BtnNew.TabIndex = 31;
			this.BtnNew.Text = "New";
			this.BtnNew.UseVisualStyleBackColor = true;
			this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 94);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 22;
			this.label1.Text = "Encoding";
			// 
			// CbEncoding
			// 
			this.CbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbEncoding.Location = new System.Drawing.Point(165, 90);
			this.CbEncoding.Margin = new System.Windows.Forms.Padding(2);
			this.CbEncoding.Name = "CbEncoding";
			this.CbEncoding.Size = new System.Drawing.Size(168, 23);
			this.CbEncoding.TabIndex = 21;
			// 
			// TxtUser
			// 
			this.TxtUser.Location = new System.Drawing.Point(116, 121);
			this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
			this.TxtUser.MaxLength = 1000;
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(240, 23);
			this.TxtUser.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(23, 125);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 15);
			this.label14.TabIndex = 32;
			this.label14.Text = "User Name";
			// 
			// TxtPass
			// 
			this.TxtPass.Location = new System.Drawing.Point(116, 148);
			this.TxtPass.Margin = new System.Windows.Forms.Padding(2);
			this.TxtPass.MaxLength = 1000;
			this.TxtPass.Name = "TxtPass";
			this.TxtPass.PasswordChar = '•';
			this.TxtPass.Size = new System.Drawing.Size(240, 23);
			this.TxtPass.TabIndex = 35;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(23, 152);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 15);
			this.label13.TabIndex = 34;
			this.label13.Text = "Password";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label15.Location = new System.Drawing.Point(113, 176);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(175, 15);
			this.label15.TabIndex = 36;
			this.label15.Text = "Your account\'s login credentials";
			// 
			// PanelProfile
			// 
			this.PanelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelProfile.AutoScroll = true;
			this.PanelProfile.Controls.Add(this.label15);
			this.PanelProfile.Controls.Add(this.TxtPass);
			this.PanelProfile.Controls.Add(this.label13);
			this.PanelProfile.Controls.Add(this.TxtUser);
			this.PanelProfile.Controls.Add(this.label14);
			this.PanelProfile.Controls.Add(this.label12);
			this.PanelProfile.Controls.Add(this.GrpManual);
			this.PanelProfile.Controls.Add(this.CbAuto);
			this.PanelProfile.Controls.Add(this.label3);
			this.PanelProfile.Controls.Add(this.label2);
			this.PanelProfile.Controls.Add(this.TxtHost);
			this.PanelProfile.Controls.Add(this.label11);
			this.PanelProfile.Controls.Add(this.NumPort);
			this.PanelProfile.Controls.Add(this.label5);
			this.PanelProfile.Controls.Add(this.TxtDisplayName);
			this.PanelProfile.Controls.Add(this.label6);
			this.PanelProfile.Controls.Add(this.label4);
			this.PanelProfile.Location = new System.Drawing.Point(324, 50);
			this.PanelProfile.Name = "PanelProfile";
			this.PanelProfile.Size = new System.Drawing.Size(404, 505);
			this.PanelProfile.TabIndex = 37;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(22, 121);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 15);
			this.label16.TabIndex = 24;
			this.label16.Text = "Data Transfer Type";
			// 
			// CbDataTrans
			// 
			this.CbDataTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDataTrans.Location = new System.Drawing.Point(165, 117);
			this.CbDataTrans.Margin = new System.Windows.Forms.Padding(2);
			this.CbDataTrans.Name = "CbDataTrans";
			this.CbDataTrans.Size = new System.Drawing.Size(168, 23);
			this.CbDataTrans.TabIndex = 23;
			// 
			// FrmServers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 567);
			this.Controls.Add(this.PanelProfile);
			this.Controls.Add(this.BtnNew);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.LstServers);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmServers";
			this.Text = "Server Manager";
			((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
			this.GrpManual.ResumeLayout(false);
			this.GrpManual.PerformLayout();
			this.PanelProfile.ResumeLayout(false);
			this.PanelProfile.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox LstServers;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox CbSecureProtocol;
		private System.Windows.Forms.ComboBox CbProtocol;
		private System.Windows.Forms.ComboBox CbDataConn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TxtDisplayName;
		private System.Windows.Forms.NumericUpDown NumPort;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtHost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox CbAuto;
		private System.Windows.Forms.GroupBox GrpManual;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnNew;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CbEncoding;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox TxtPass;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel PanelProfile;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox CbDataTrans;
	}
}