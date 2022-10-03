namespace FlameFTP.Forms {
	partial class FrmOptions
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabProfile = new System.Windows.Forms.TabPage();
			this.comboBoxDataConnection = new System.Windows.Forms.ComboBox();
			this.comboBoxEncryption = new System.Windows.Forms.ComboBox();
			this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
			this.textBoxSiteName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBoxPortNo = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.textBoxHostName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.TabUser = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.TabProfile.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabProfile);
			this.tabControl1.Controls.Add(this.TabUser);
			this.tabControl1.Location = new System.Drawing.Point(25, 45);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(913, 453);
			this.tabControl1.TabIndex = 0;
			// 
			// TabProfile
			// 
			this.TabProfile.Controls.Add(this.label9);
			this.TabProfile.Controls.Add(this.label8);
			this.TabProfile.Controls.Add(this.label7);
			this.TabProfile.Controls.Add(this.comboBoxDataConnection);
			this.TabProfile.Controls.Add(this.comboBoxEncryption);
			this.TabProfile.Controls.Add(this.comboBoxProtocol);
			this.TabProfile.Controls.Add(this.textBoxSiteName);
			this.TabProfile.Controls.Add(this.label6);
			this.TabProfile.Controls.Add(this.button3);
			this.TabProfile.Controls.Add(this.textBoxPortNo);
			this.TabProfile.Controls.Add(this.textBoxPassword);
			this.TabProfile.Controls.Add(this.textBoxUserName);
			this.TabProfile.Controls.Add(this.textBoxHostName);
			this.TabProfile.Controls.Add(this.label4);
			this.TabProfile.Controls.Add(this.label3);
			this.TabProfile.Controls.Add(this.label2);
			this.TabProfile.Controls.Add(this.label5);
			this.TabProfile.Controls.Add(this.button2);
			this.TabProfile.Controls.Add(this.button1);
			this.TabProfile.Controls.Add(this.label1);
			this.TabProfile.Controls.Add(this.listBox1);
			this.TabProfile.Location = new System.Drawing.Point(4, 25);
			this.TabProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabProfile.Name = "TabProfile";
			this.TabProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabProfile.Size = new System.Drawing.Size(905, 424);
			this.TabProfile.TabIndex = 0;
			this.TabProfile.Text = "Profiles";
			this.TabProfile.UseVisualStyleBackColor = true;
			// 
			// comboBoxDataConnection
			// 
			this.comboBoxDataConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataConnection.Enabled = false;
			this.comboBoxDataConnection.FormattingEnabled = true;
			this.comboBoxDataConnection.Location = new System.Drawing.Point(539, 295);
			this.comboBoxDataConnection.Name = "comboBoxDataConnection";
			this.comboBoxDataConnection.Size = new System.Drawing.Size(121, 24);
			this.comboBoxDataConnection.TabIndex = 17;
			// 
			// comboBoxEncryption
			// 
			this.comboBoxEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEncryption.Enabled = false;
			this.comboBoxEncryption.FormattingEnabled = true;
			this.comboBoxEncryption.Location = new System.Drawing.Point(539, 252);
			this.comboBoxEncryption.Name = "comboBoxEncryption";
			this.comboBoxEncryption.Size = new System.Drawing.Size(121, 24);
			this.comboBoxEncryption.TabIndex = 16;
			// 
			// comboBoxProtocol
			// 
			this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProtocol.FormattingEnabled = true;
			this.comboBoxProtocol.Location = new System.Drawing.Point(539, 209);
			this.comboBoxProtocol.Name = "comboBoxProtocol";
			this.comboBoxProtocol.Size = new System.Drawing.Size(121, 24);
			this.comboBoxProtocol.TabIndex = 15;
			// 
			// textBoxSiteName
			// 
			this.textBoxSiteName.Location = new System.Drawing.Point(538, 37);
			this.textBoxSiteName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxSiteName.Name = "textBoxSiteName";
			this.textBoxSiteName.ReadOnly = true;
			this.textBoxSiteName.Size = new System.Drawing.Size(273, 22);
			this.textBoxSiteName.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(441, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 14;
			this.label6.Text = "Site Name";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(306, 127);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 38);
			this.button3.TabIndex = 12;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBoxPortNo
			// 
			this.textBoxPortNo.Location = new System.Drawing.Point(539, 101);
			this.textBoxPortNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPortNo.Name = "textBoxPortNo";
			this.textBoxPortNo.ReadOnly = true;
			this.textBoxPortNo.Size = new System.Drawing.Size(273, 22);
			this.textBoxPortNo.TabIndex = 6;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(539, 164);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.ReadOnly = true;
			this.textBoxPassword.Size = new System.Drawing.Size(273, 22);
			this.textBoxPassword.TabIndex = 10;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(539, 133);
			this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.ReadOnly = true;
			this.textBoxUserName.Size = new System.Drawing.Size(273, 22);
			this.textBoxUserName.TabIndex = 8;
			// 
			// textBoxHostName
			// 
			this.textBoxHostName.Location = new System.Drawing.Point(539, 68);
			this.textBoxHostName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxHostName.Name = "textBoxHostName";
			this.textBoxHostName.ReadOnly = true;
			this.textBoxHostName.Size = new System.Drawing.Size(273, 22);
			this.textBoxHostName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(442, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(442, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(442, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Username";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(442, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Hostname";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(305, 85);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 38);
			this.button2.TabIndex = 3;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(305, 42);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 38);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add New";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Profiles";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(23, 42);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(267, 356);
			this.listBox1.TabIndex = 0;
			this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// TabUser
			// 
			this.TabUser.Location = new System.Drawing.Point(4, 25);
			this.TabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabUser.Name = "TabUser";
			this.TabUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabUser.Size = new System.Drawing.Size(905, 424);
			this.TabUser.TabIndex = 1;
			this.TabUser.Text = "User Details";
			this.TabUser.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(401, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(114, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "Encryption Mode";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(454, 209);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "Protocol";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(374, 302);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 17);
			this.label9.TabIndex = 20;
			this.label9.Text = "Dat Connection Type";
			// 
			// FrmOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 515);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmOptions";
			this.Text = "Site Manager";
			this.tabControl1.ResumeLayout(false);
			this.TabProfile.ResumeLayout(false);
			this.TabProfile.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabUser;
		private System.Windows.Forms.TabPage TabProfile;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		internal System.Windows.Forms.TextBox textBoxPortNo;
		internal System.Windows.Forms.TextBox textBoxPassword;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.TextBox textBoxHostName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.TextBox textBoxSiteName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxEncryption;
		private System.Windows.Forms.ComboBox comboBoxProtocol;
		private System.Windows.Forms.ComboBox comboBoxDataConnection;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}