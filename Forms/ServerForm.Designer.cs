namespace FlameFTP.Forms {
	partial class ServerForm
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
			this.BtnSave = new FontAwesome.Sharp.IconButton();
			this.LstServers = new System.Windows.Forms.ListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.NumPort = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtHost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CbAuto = new System.Windows.Forms.CheckBox();
			this.label16 = new System.Windows.Forms.Label();
			this.CbDataTrans = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CbEncoding = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.BtnDelete = new FontAwesome.Sharp.IconButton();
			this.BtnNew = new FontAwesome.Sharp.IconButton();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.TxtPass = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.PanelProfile = new System.Windows.Forms.Panel();
			this.GrpProxy = new System.Windows.Forms.Panel();
			this.CbProxyType = new System.Windows.Forms.ComboBox();
			this.TxtProxyHost = new System.Windows.Forms.TextBox();
			this.TxtProxyPass = new System.Windows.Forms.TextBox();
			this.TxtProxyUser = new System.Windows.Forms.TextBox();
			this.NumProxyPort = new System.Windows.Forms.NumericUpDown();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.GrpConnection = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.CbProxy = new System.Windows.Forms.CheckBox();
			this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
			this.label18 = new System.Windows.Forms.Label();
			this.TxtLocalPath = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.TxtServerPath = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
			this.PanelProfile.SuspendLayout();
			this.GrpProxy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumProxyPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
			this.GrpConnection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 125);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 15);
			this.label9.TabIndex = 20;
			this.label9.Text = "Data Connection Type";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 17);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "FTPS";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 44);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "FTPS Protocol";
			// 
			// CbDataConn
			// 
			this.CbDataConn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDataConn.Location = new System.Drawing.Point(130, 122);
			this.CbDataConn.Margin = new System.Windows.Forms.Padding(2);
			this.CbDataConn.Name = "CbDataConn";
			this.CbDataConn.Size = new System.Drawing.Size(243, 23);
			this.CbDataConn.TabIndex = 17;
			// 
			// CbSecureProtocol
			// 
			this.CbSecureProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbSecureProtocol.Location = new System.Drawing.Point(130, 41);
			this.CbSecureProtocol.Margin = new System.Windows.Forms.Padding(2);
			this.CbSecureProtocol.Name = "CbSecureProtocol";
			this.CbSecureProtocol.Size = new System.Drawing.Size(243, 23);
			this.CbSecureProtocol.TabIndex = 16;
			// 
			// CbProtocol
			// 
			this.CbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbProtocol.Location = new System.Drawing.Point(130, 14);
			this.CbProtocol.Margin = new System.Windows.Forms.Padding(2);
			this.CbProtocol.Name = "CbProtocol";
			this.CbProtocol.Size = new System.Drawing.Size(243, 23);
			this.CbProtocol.TabIndex = 15;
			// 
			// TxtDisplayName
			// 
			this.TxtDisplayName.Location = new System.Drawing.Point(152, 10);
			this.TxtDisplayName.Margin = new System.Windows.Forms.Padding(2);
			this.TxtDisplayName.MaxLength = 1000;
			this.TxtDisplayName.Name = "TxtDisplayName";
			this.TxtDisplayName.Size = new System.Drawing.Size(240, 23);
			this.TxtDisplayName.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 13);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Display Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 205);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Port";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 67);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Host Name";
			// 
			// BtnSave
			// 
			this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
			this.BtnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.BtnSave.IconSize = 20;
			this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSave.Location = new System.Drawing.Point(115, 626);
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
			this.LstServers.IntegralHeight = false;
			this.LstServers.ItemHeight = 15;
			this.LstServers.Location = new System.Drawing.Point(11, 48);
			this.LstServers.Margin = new System.Windows.Forms.Padding(2);
			this.LstServers.Name = "LstServers";
			this.LstServers.ScrollAlwaysVisible = true;
			this.LstServers.Size = new System.Drawing.Size(309, 574);
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
			this.label10.Size = new System.Drawing.Size(756, 37);
			this.label10.TabIndex = 21;
			this.label10.Text = "SERVERS";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumPort
			// 
			this.NumPort.Location = new System.Drawing.Point(152, 202);
			this.NumPort.Name = "NumPort";
			this.NumPort.Size = new System.Drawing.Size(120, 23);
			this.NumPort.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label11.Location = new System.Drawing.Point(151, 36);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(253, 15);
			this.label11.TabIndex = 23;
			this.label11.Text = "Any name you would remember this server by.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(151, 89);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 15);
			this.label2.TabIndex = 25;
			this.label2.Text = "The server\'s domain or IP address.";
			// 
			// TxtHost
			// 
			this.TxtHost.Location = new System.Drawing.Point(152, 63);
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
			this.label3.Location = new System.Drawing.Point(151, 228);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 15);
			this.label3.TabIndex = 26;
			this.label3.Text = "Which port to connect to (use 0 for automatic).";
			// 
			// CbAuto
			// 
			this.CbAuto.AutoSize = true;
			this.CbAuto.Location = new System.Drawing.Point(152, 346);
			this.CbAuto.Name = "CbAuto";
			this.CbAuto.Size = new System.Drawing.Size(100, 19);
			this.CbAuto.TabIndex = 27;
			this.CbAuto.Text = "Auto Connect";
			this.CbAuto.UseVisualStyleBackColor = true;
			this.CbAuto.CheckedChanged += new System.EventHandler(this.CbAuto_CheckedChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 98);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 15);
			this.label16.TabIndex = 24;
			this.label16.Text = "Data Transfer Type";
			// 
			// CbDataTrans
			// 
			this.CbDataTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDataTrans.Location = new System.Drawing.Point(130, 95);
			this.CbDataTrans.Margin = new System.Windows.Forms.Padding(2);
			this.CbDataTrans.Name = "CbDataTrans";
			this.CbDataTrans.Size = new System.Drawing.Size(243, 23);
			this.CbDataTrans.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 71);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 22;
			this.label1.Text = "Encoding";
			// 
			// CbEncoding
			// 
			this.CbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbEncoding.Location = new System.Drawing.Point(130, 68);
			this.CbEncoding.Margin = new System.Windows.Forms.Padding(2);
			this.CbEncoding.Name = "CbEncoding";
			this.CbEncoding.Size = new System.Drawing.Size(243, 23);
			this.CbEncoding.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(44, 346);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 15);
			this.label12.TabIndex = 29;
			this.label12.Text = "Connection";
			// 
			// BtnDelete
			// 
			this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
			this.BtnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.BtnDelete.IconSize = 20;
			this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnDelete.Location = new System.Drawing.Point(219, 626);
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
			this.BtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.BtnNew.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.BtnNew.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.BtnNew.IconSize = 20;
			this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnNew.Location = new System.Drawing.Point(11, 626);
			this.BtnNew.Margin = new System.Windows.Forms.Padding(2);
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.Size = new System.Drawing.Size(100, 25);
			this.BtnNew.TabIndex = 31;
			this.BtnNew.Text = "New";
			this.BtnNew.UseVisualStyleBackColor = true;
			this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
			// 
			// TxtUser
			// 
			this.TxtUser.Location = new System.Drawing.Point(152, 118);
			this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
			this.TxtUser.MaxLength = 1000;
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(240, 23);
			this.TxtUser.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(44, 122);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 15);
			this.label14.TabIndex = 32;
			this.label14.Text = "User Name";
			// 
			// TxtPass
			// 
			this.TxtPass.Location = new System.Drawing.Point(152, 145);
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
			this.label13.Location = new System.Drawing.Point(44, 149);
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
			this.label15.Location = new System.Drawing.Point(149, 173);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(124, 15);
			this.label15.TabIndex = 36;
			this.label15.Text = "Your login credentials.";
			// 
			// PanelProfile
			// 
			this.PanelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelProfile.AutoScroll = true;
			this.PanelProfile.Controls.Add(this.GrpProxy);
			this.PanelProfile.Controls.Add(this.iconPictureBox3);
			this.PanelProfile.Controls.Add(this.label22);
			this.PanelProfile.Controls.Add(this.GrpConnection);
			this.PanelProfile.Controls.Add(this.label21);
			this.PanelProfile.Controls.Add(this.CbProxy);
			this.PanelProfile.Controls.Add(this.iconPictureBox7);
			this.PanelProfile.Controls.Add(this.label18);
			this.PanelProfile.Controls.Add(this.TxtLocalPath);
			this.PanelProfile.Controls.Add(this.label19);
			this.PanelProfile.Controls.Add(this.TxtServerPath);
			this.PanelProfile.Controls.Add(this.label20);
			this.PanelProfile.Controls.Add(this.label17);
			this.PanelProfile.Controls.Add(this.iconPictureBox6);
			this.PanelProfile.Controls.Add(this.iconPictureBox5);
			this.PanelProfile.Controls.Add(this.iconPictureBox4);
			this.PanelProfile.Controls.Add(this.iconPictureBox2);
			this.PanelProfile.Controls.Add(this.iconPictureBox1);
			this.PanelProfile.Controls.Add(this.label15);
			this.PanelProfile.Controls.Add(this.TxtPass);
			this.PanelProfile.Controls.Add(this.label13);
			this.PanelProfile.Controls.Add(this.TxtUser);
			this.PanelProfile.Controls.Add(this.label14);
			this.PanelProfile.Controls.Add(this.label12);
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
			this.PanelProfile.Size = new System.Drawing.Size(432, 612);
			this.PanelProfile.TabIndex = 37;
			// 
			// GrpProxy
			// 
			this.GrpProxy.Controls.Add(this.CbProxyType);
			this.GrpProxy.Controls.Add(this.TxtProxyHost);
			this.GrpProxy.Controls.Add(this.TxtProxyPass);
			this.GrpProxy.Controls.Add(this.TxtProxyUser);
			this.GrpProxy.Controls.Add(this.NumProxyPort);
			this.GrpProxy.Controls.Add(this.label23);
			this.GrpProxy.Controls.Add(this.label24);
			this.GrpProxy.Controls.Add(this.label25);
			this.GrpProxy.Controls.Add(this.label26);
			this.GrpProxy.Controls.Add(this.label27);
			this.GrpProxy.Enabled = false;
			this.GrpProxy.Location = new System.Drawing.Point(21, 611);
			this.GrpProxy.Name = "GrpProxy";
			this.GrpProxy.Size = new System.Drawing.Size(383, 165);
			this.GrpProxy.TabIndex = 26;
			// 
			// CbProxyType
			// 
			this.CbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbProxyType.Location = new System.Drawing.Point(130, 14);
			this.CbProxyType.Margin = new System.Windows.Forms.Padding(2);
			this.CbProxyType.Name = "CbProxyType";
			this.CbProxyType.Size = new System.Drawing.Size(240, 23);
			this.CbProxyType.TabIndex = 39;
			// 
			// TxtProxyHost
			// 
			this.TxtProxyHost.Location = new System.Drawing.Point(130, 41);
			this.TxtProxyHost.Margin = new System.Windows.Forms.Padding(2);
			this.TxtProxyHost.MaxLength = 1000;
			this.TxtProxyHost.Name = "TxtProxyHost";
			this.TxtProxyHost.Size = new System.Drawing.Size(240, 23);
			this.TxtProxyHost.TabIndex = 38;
			// 
			// TxtProxyPass
			// 
			this.TxtProxyPass.Location = new System.Drawing.Point(130, 95);
			this.TxtProxyPass.Margin = new System.Windows.Forms.Padding(2);
			this.TxtProxyPass.MaxLength = 1000;
			this.TxtProxyPass.Name = "TxtProxyPass";
			this.TxtProxyPass.PasswordChar = '•';
			this.TxtProxyPass.Size = new System.Drawing.Size(240, 23);
			this.TxtProxyPass.TabIndex = 37;
			// 
			// TxtProxyUser
			// 
			this.TxtProxyUser.Location = new System.Drawing.Point(130, 68);
			this.TxtProxyUser.Margin = new System.Windows.Forms.Padding(2);
			this.TxtProxyUser.MaxLength = 1000;
			this.TxtProxyUser.Name = "TxtProxyUser";
			this.TxtProxyUser.Size = new System.Drawing.Size(240, 23);
			this.TxtProxyUser.TabIndex = 36;
			// 
			// NumProxyPort
			// 
			this.NumProxyPort.Location = new System.Drawing.Point(130, 123);
			this.NumProxyPort.Name = "NumProxyPort";
			this.NumProxyPort.Size = new System.Drawing.Size(120, 23);
			this.NumProxyPort.TabIndex = 25;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(6, 98);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(90, 15);
			this.label23.TabIndex = 24;
			this.label23.Text = "Proxy Password";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 71);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(98, 15);
			this.label24.TabIndex = 22;
			this.label24.Text = "Proxy User Name";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(6, 125);
			this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(62, 15);
			this.label25.TabIndex = 20;
			this.label25.Text = "Proxy Port";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 17);
			this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(64, 15);
			this.label26.TabIndex = 19;
			this.label26.Text = "Proxy Type";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(6, 44);
			this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(65, 15);
			this.label27.TabIndex = 18;
			this.label27.Text = "Proxy Host";
			// 
			// iconPictureBox3
			// 
			this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
			this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox3.IconSize = 26;
			this.iconPictureBox3.Location = new System.Drawing.Point(18, 566);
			this.iconPictureBox3.Name = "iconPictureBox3";
			this.iconPictureBox3.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox3.TabIndex = 55;
			this.iconPictureBox3.TabStop = false;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(44, 569);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(37, 15);
			this.label22.TabIndex = 54;
			this.label22.Text = "Proxy";
			// 
			// GrpConnection
			// 
			this.GrpConnection.Controls.Add(this.label16);
			this.GrpConnection.Controls.Add(this.CbDataTrans);
			this.GrpConnection.Controls.Add(this.label1);
			this.GrpConnection.Controls.Add(this.CbEncoding);
			this.GrpConnection.Controls.Add(this.label9);
			this.GrpConnection.Controls.Add(this.label8);
			this.GrpConnection.Controls.Add(this.label7);
			this.GrpConnection.Controls.Add(this.CbDataConn);
			this.GrpConnection.Controls.Add(this.CbSecureProtocol);
			this.GrpConnection.Controls.Add(this.CbProtocol);
			this.GrpConnection.Location = new System.Drawing.Point(21, 386);
			this.GrpConnection.Name = "GrpConnection";
			this.GrpConnection.Size = new System.Drawing.Size(383, 165);
			this.GrpConnection.TabIndex = 25;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label21.Location = new System.Drawing.Point(149, 591);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(206, 15);
			this.label21.TabIndex = 53;
			this.label21.Text = "Connect through an FTP proxy server.";
			// 
			// CbProxy
			// 
			this.CbProxy.AutoSize = true;
			this.CbProxy.Location = new System.Drawing.Point(152, 569);
			this.CbProxy.Name = "CbProxy";
			this.CbProxy.Size = new System.Drawing.Size(78, 19);
			this.CbProxy.TabIndex = 50;
			this.CbProxy.Text = "FTP Proxy";
			this.CbProxy.UseVisualStyleBackColor = true;
			this.CbProxy.CheckedChanged += new System.EventHandler(this.CbProxy_CheckedChanged);
			// 
			// iconPictureBox7
			// 
			this.iconPictureBox7.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
			this.iconPictureBox7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox7.IconSize = 26;
			this.iconPictureBox7.Location = new System.Drawing.Point(18, 259);
			this.iconPictureBox7.Name = "iconPictureBox7";
			this.iconPictureBox7.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox7.TabIndex = 49;
			this.iconPictureBox7.TabStop = false;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label18.Location = new System.Drawing.Point(149, 313);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(243, 15);
			this.label18.TabIndex = 48;
			this.label18.Text = "Which folders to browse to after we connect.";
			// 
			// TxtLocalPath
			// 
			this.TxtLocalPath.Location = new System.Drawing.Point(152, 285);
			this.TxtLocalPath.Margin = new System.Windows.Forms.Padding(2);
			this.TxtLocalPath.MaxLength = 1000;
			this.TxtLocalPath.Name = "TxtLocalPath";
			this.TxtLocalPath.PasswordChar = '•';
			this.TxtLocalPath.Size = new System.Drawing.Size(240, 23);
			this.TxtLocalPath.TabIndex = 47;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(44, 289);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(94, 15);
			this.label19.TabIndex = 46;
			this.label19.Text = "Initial Local Path";
			// 
			// TxtServerPath
			// 
			this.TxtServerPath.Location = new System.Drawing.Point(152, 258);
			this.TxtServerPath.Margin = new System.Windows.Forms.Padding(2);
			this.TxtServerPath.MaxLength = 1000;
			this.TxtServerPath.Name = "TxtServerPath";
			this.TxtServerPath.Size = new System.Drawing.Size(240, 23);
			this.TxtServerPath.TabIndex = 45;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(44, 262);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(98, 15);
			this.label20.TabIndex = 44;
			this.label20.Text = "Initial Server Path";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label17.Location = new System.Drawing.Point(149, 368);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(227, 15);
			this.label17.TabIndex = 43;
			this.label17.Text = "Automatically detect connection settings.";
			// 
			// iconPictureBox6
			// 
			this.iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Link;
			this.iconPictureBox6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox6.IconSize = 26;
			this.iconPictureBox6.Location = new System.Drawing.Point(18, 343);
			this.iconPictureBox6.Name = "iconPictureBox6";
			this.iconPictureBox6.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox6.TabIndex = 42;
			this.iconPictureBox6.TabStop = false;
			// 
			// iconPictureBox5
			// 
			this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Plug;
			this.iconPictureBox5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox5.IconSize = 26;
			this.iconPictureBox5.Location = new System.Drawing.Point(18, 201);
			this.iconPictureBox5.Name = "iconPictureBox5";
			this.iconPictureBox5.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox5.TabIndex = 41;
			this.iconPictureBox5.TabStop = false;
			// 
			// iconPictureBox4
			// 
			this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
			this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox4.IconSize = 26;
			this.iconPictureBox4.Location = new System.Drawing.Point(18, 119);
			this.iconPictureBox4.Name = "iconPictureBox4";
			this.iconPictureBox4.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox4.TabIndex = 40;
			this.iconPictureBox4.TabStop = false;
			// 
			// iconPictureBox2
			// 
			this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Server;
			this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox2.IconSize = 26;
			this.iconPictureBox2.Location = new System.Drawing.Point(18, 64);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox2.TabIndex = 38;
			this.iconPictureBox2.TabStop = false;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Star;
			this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconPictureBox1.IconSize = 26;
			this.iconPictureBox1.Location = new System.Drawing.Point(18, 9);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(26, 26);
			this.iconPictureBox1.TabIndex = 37;
			this.iconPictureBox1.TabStop = false;
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 662);
			this.Controls.Add(this.PanelProfile);
			this.Controls.Add(this.BtnNew);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.LstServers);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ServerForm";
			this.Text = "Server Manager";
			((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
			this.PanelProfile.ResumeLayout(false);
			this.PanelProfile.PerformLayout();
			this.GrpProxy.ResumeLayout(false);
			this.GrpProxy.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumProxyPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
			this.GrpConnection.ResumeLayout(false);
			this.GrpConnection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox LstServers;
		private FontAwesome.Sharp.IconButton BtnSave;
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
		private System.Windows.Forms.Label label12;
		private FontAwesome.Sharp.IconButton BtnDelete;
		private FontAwesome.Sharp.IconButton BtnNew;
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
		private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
		private System.Windows.Forms.Label label17;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox TxtLocalPath;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox TxtServerPath;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox CbProxy;
		private System.Windows.Forms.Panel GrpConnection;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel GrpProxy;
		private System.Windows.Forms.ComboBox CbProxyType;
		private System.Windows.Forms.TextBox TxtProxyHost;
		private System.Windows.Forms.TextBox TxtProxyPass;
		private System.Windows.Forms.TextBox TxtProxyUser;
		private System.Windows.Forms.NumericUpDown NumProxyPort;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
	}
}