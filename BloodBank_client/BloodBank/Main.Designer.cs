namespace BloodBank
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_passwordLogin = new System.Windows.Forms.TextBox();
            this.textBox_usernameLogin = new System.Windows.Forms.TextBox();
            this.button_createAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Playbill", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(440, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 65);
            this.label5.TabIndex = 8;
            this.label5.Text = "BLOOD BANK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(620, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "You are not registered?";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_login.Location = new System.Drawing.Point(462, 189);
            this.button_login.Margin = new System.Windows.Forms.Padding(0);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(194, 49);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(459, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(457, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "USERNAME:";
            // 
            // textBox_passwordLogin
            // 
            this.textBox_passwordLogin.BackColor = System.Drawing.Color.LightGray;
            this.textBox_passwordLogin.Location = new System.Drawing.Point(554, 166);
            this.textBox_passwordLogin.Name = "textBox_passwordLogin";
            this.textBox_passwordLogin.PasswordChar = '*';
            this.textBox_passwordLogin.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwordLogin.TabIndex = 11;
            // 
            // textBox_usernameLogin
            // 
            this.textBox_usernameLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_usernameLogin.ForeColor = System.Drawing.Color.Black;
            this.textBox_usernameLogin.Location = new System.Drawing.Point(554, 124);
            this.textBox_usernameLogin.Name = "textBox_usernameLogin";
            this.textBox_usernameLogin.Size = new System.Drawing.Size(100, 20);
            this.textBox_usernameLogin.TabIndex = 10;
            // 
            // button_createAccount
            // 
            this.button_createAccount.AutoSize = true;
            this.button_createAccount.BackColor = System.Drawing.Color.Transparent;
            this.button_createAccount.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createAccount.ForeColor = System.Drawing.Color.Blue;
            this.button_createAccount.Location = new System.Drawing.Point(581, 376);
            this.button_createAccount.Name = "button_createAccount";
            this.button_createAccount.Size = new System.Drawing.Size(156, 20);
            this.button_createAccount.TabIndex = 9;
            this.button_createAccount.Text = "CREATE ACCOUNT";
            this.button_createAccount.Click += new System.EventHandler(this.createacc_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_passwordLogin);
            this.Controls.Add(this.textBox_usernameLogin);
            this.Controls.Add(this.button_createAccount);
            this.Controls.Add(this.label5);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox_passwordLogin;
		public System.Windows.Forms.TextBox textBox_usernameLogin;
		private System.Windows.Forms.Label button_createAccount;
	}
}

