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
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(330, 316);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 15);
			this.label9.TabIndex = 20;
			this.label9.Text = "Data Connection Type";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(400, 229);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "Protocol";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(354, 272);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "Encryption Mode";
			// 
			// comboBoxDataConnection
			// 
			this.comboBoxDataConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataConnection.Enabled = false;
			this.comboBoxDataConnection.FormattingEnabled = true;
			this.comboBoxDataConnection.Location = new System.Drawing.Point(474, 310);
			this.comboBoxDataConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxDataConnection.Name = "comboBoxDataConnection";
			this.comboBoxDataConnection.Size = new System.Drawing.Size(107, 23);
			this.comboBoxDataConnection.TabIndex = 17;
			// 
			// comboBoxEncryption
			// 
			this.comboBoxEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEncryption.Enabled = false;
			this.comboBoxEncryption.FormattingEnabled = true;
			this.comboBoxEncryption.Location = new System.Drawing.Point(474, 270);
			this.comboBoxEncryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxEncryption.Name = "comboBoxEncryption";
			this.comboBoxEncryption.Size = new System.Drawing.Size(107, 23);
			this.comboBoxEncryption.TabIndex = 16;
			// 
			// comboBoxProtocol
			// 
			this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProtocol.FormattingEnabled = true;
			this.comboBoxProtocol.Location = new System.Drawing.Point(474, 229);
			this.comboBoxProtocol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxProtocol.Name = "comboBoxProtocol";
			this.comboBoxProtocol.Size = new System.Drawing.Size(107, 23);
			this.comboBoxProtocol.TabIndex = 15;
			// 
			// textBoxSiteName
			// 
			this.textBoxSiteName.Location = new System.Drawing.Point(474, 68);
			this.textBoxSiteName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxSiteName.Name = "textBoxSiteName";
			this.textBoxSiteName.ReadOnly = true;
			this.textBoxSiteName.Size = new System.Drawing.Size(240, 23);
			this.textBoxSiteName.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(389, 70);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Site Name";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(271, 152);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(79, 36);
			this.button3.TabIndex = 12;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBoxPortNo
			// 
			this.textBoxPortNo.Location = new System.Drawing.Point(474, 128);
			this.textBoxPortNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPortNo.Name = "textBoxPortNo";
			this.textBoxPortNo.ReadOnly = true;
			this.textBoxPortNo.Size = new System.Drawing.Size(240, 23);
			this.textBoxPortNo.TabIndex = 6;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(474, 186);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.ReadOnly = true;
			this.textBoxPassword.Size = new System.Drawing.Size(240, 23);
			this.textBoxPassword.TabIndex = 10;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(474, 158);
			this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.ReadOnly = true;
			this.textBoxUserName.Size = new System.Drawing.Size(240, 23);
			this.textBoxUserName.TabIndex = 8;
			// 
			// textBoxHostName
			// 
			this.textBoxHostName.Location = new System.Drawing.Point(474, 96);
			this.textBoxHostName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxHostName.Name = "textBoxHostName";
			this.textBoxHostName.ReadOnly = true;
			this.textBoxHostName.Size = new System.Drawing.Size(240, 23);
			this.textBoxHostName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(390, 132);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(390, 191);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(390, 162);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Username";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(390, 99);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Hostname";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(270, 113);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(79, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(270, 72);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 36);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add New";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 56);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Profiles";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(23, 72);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(234, 334);
			this.listBox1.TabIndex = 0;
			this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(11)))), ((int)(((byte)(255)))));
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(736, 37);
			this.label10.TabIndex = 21;
			this.label10.Text = "SERVERS";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmServers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 444);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxDataConnection);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBoxEncryption);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBoxProtocol);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSiteName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPortNo);
			this.Controls.Add(this.textBoxHostName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmServers";
			this.Text = "Server Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
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
		private System.Windows.Forms.Label label10;
	}
}