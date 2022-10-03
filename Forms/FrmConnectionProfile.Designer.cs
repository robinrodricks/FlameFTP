namespace FlameFTP.Forms {
	partial class FrmConnectionProfile
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxHostName = new System.Windows.Forms.TextBox();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxPortNo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxSiteName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxDataConnection = new System.Windows.Forms.ComboBox();
			this.comboBoxEncryption = new System.Windows.Forms.ComboBox();
			this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
			this.lblproto = new System.Windows.Forms.Label();
			this.lbldata = new System.Windows.Forms.Label();
			this.lblenc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hostname";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Port";
			// 
			// textBoxHostName
			// 
			this.textBoxHostName.Location = new System.Drawing.Point(146, 58);
			this.textBoxHostName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxHostName.Name = "textBoxHostName";
			this.textBoxHostName.Size = new System.Drawing.Size(273, 22);
			this.textBoxHostName.TabIndex = 0;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(146, 128);
			this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(273, 22);
			this.textBoxUserName.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(146, 159);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(273, 22);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// textBoxPortNo
			// 
			this.textBoxPortNo.Location = new System.Drawing.Point(146, 91);
			this.textBoxPortNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPortNo.Name = "textBoxPortNo";
			this.textBoxPortNo.Size = new System.Drawing.Size(273, 22);
			this.textBoxPortNo.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(130, 363);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 63);
			this.button1.TabIndex = 5;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(315, 363);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 63);
			this.button2.TabIndex = 4;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBoxSiteName
			// 
			this.textBoxSiteName.Location = new System.Drawing.Point(146, 24);
			this.textBoxSiteName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxSiteName.Name = "textBoxSiteName";
			this.textBoxSiteName.Size = new System.Drawing.Size(273, 22);
			this.textBoxSiteName.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Site Name";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 289);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 46);
			this.label9.TabIndex = 26;
			this.label9.Text = "Dat Connection Type";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(61, 196);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 25;
			this.label8.Text = "Protocol";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(44, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 46);
			this.label7.TabIndex = 24;
			this.label7.Text = "Encryption Mode";
			// 
			// comboBoxDataConnection
			// 
			this.comboBoxDataConnection.FormattingEnabled = true;
			this.comboBoxDataConnection.Location = new System.Drawing.Point(146, 286);
			this.comboBoxDataConnection.Name = "comboBoxDataConnection";
			this.comboBoxDataConnection.Size = new System.Drawing.Size(121, 24);
			this.comboBoxDataConnection.TabIndex = 23;
			// 
			// comboBoxEncryption
			// 
			this.comboBoxEncryption.FormattingEnabled = true;
			this.comboBoxEncryption.Location = new System.Drawing.Point(146, 240);
			this.comboBoxEncryption.Name = "comboBoxEncryption";
			this.comboBoxEncryption.Size = new System.Drawing.Size(121, 24);
			this.comboBoxEncryption.TabIndex = 22;
			// 
			// comboBoxProtocol
			// 
			this.comboBoxProtocol.FormattingEnabled = true;
			this.comboBoxProtocol.Location = new System.Drawing.Point(146, 196);
			this.comboBoxProtocol.Name = "comboBoxProtocol";
			this.comboBoxProtocol.Size = new System.Drawing.Size(121, 24);
			this.comboBoxProtocol.TabIndex = 21;
			// 
			// lblproto
			// 
			this.lblproto.AutoSize = true;
			this.lblproto.Location = new System.Drawing.Point(312, 203);
			this.lblproto.Name = "lblproto";
			this.lblproto.Size = new System.Drawing.Size(46, 17);
			this.lblproto.TabIndex = 27;
			this.lblproto.Text = "label6";
			// 
			// lbldata
			// 
			this.lbldata.AutoSize = true;
			this.lbldata.Location = new System.Drawing.Point(312, 289);
			this.lbldata.Name = "lbldata";
			this.lbldata.Size = new System.Drawing.Size(54, 17);
			this.lbldata.TabIndex = 28;
			this.lbldata.Text = "label10";
			// 
			// lblenc
			// 
			this.lblenc.AutoSize = true;
			this.lblenc.Location = new System.Drawing.Point(312, 243);
			this.lblenc.Name = "lblenc";
			this.lblenc.Size = new System.Drawing.Size(54, 17);
			this.lblenc.TabIndex = 29;
			this.lblenc.Text = "label11";
			// 
			// FrmConnectionProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 464);
			this.Controls.Add(this.lblenc);
			this.Controls.Add(this.lbldata);
			this.Controls.Add(this.lblproto);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxDataConnection);
			this.Controls.Add(this.comboBoxEncryption);
			this.Controls.Add(this.comboBoxProtocol);
			this.Controls.Add(this.textBoxSiteName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxPortNo);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.textBoxHostName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmConnectionProfile";
			this.Text = "Login Details";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		internal System.Windows.Forms.TextBox textBoxHostName;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.TextBox textBoxPassword;
		internal System.Windows.Forms.TextBox textBoxPortNo;
		internal System.Windows.Forms.TextBox textBoxSiteName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox comboBoxDataConnection;
		public System.Windows.Forms.ComboBox comboBoxEncryption;
		public System.Windows.Forms.ComboBox comboBoxProtocol;
		public System.Windows.Forms.Label lblproto;
		public System.Windows.Forms.Label lbldata;
		public System.Windows.Forms.Label lblenc;
	}
}