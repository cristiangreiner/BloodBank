namespace BloodBank
{
	partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.label21 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_donate = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.editpan = new System.Windows.Forms.Panel();
            this.button_deleteAccount = new System.Windows.Forms.Button();
            this.button_updateDonorDetails = new System.Windows.Forms.Button();
            this.textBox_updateCNP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateOfBirth_update = new System.Windows.Forms.DateTimePicker();
            this.close4 = new System.Windows.Forms.Label();
            this.textBox_updatePassword = new System.Windows.Forms.TextBox();
            this.textBox_updateUsername = new System.Windows.Forms.TextBox();
            this.textBox_updateLatName = new System.Windows.Forms.TextBox();
            this.textBox_updateFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_donations = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_futureDonations = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView_pastDonations = new System.Windows.Forms.ListView();
            this.close3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_email = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_centerEmail = new System.Windows.Forms.Label();
            this.label_centerAddress = new System.Windows.Forms.Label();
            this.dateTimePicker_donation = new System.Windows.Forms.DateTimePicker();
            this.comboBox_town = new System.Windows.Forms.ComboBox();
            this.label_Town = new System.Windows.Forms.Label();
            this.button_scheduleDonation = new System.Windows.Forms.Button();
            this.comboBox_county = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.close2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button_editAccount = new System.Windows.Forms.Button();
            this.button_myDonations = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.editpan.SuspendLayout();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_donations.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Welcome,";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(68, 19);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(121, 13);
            this.label_username.TabIndex = 22;
            this.label_username.Text = "username goes here";
            // 
            // button_donate
            // 
            this.button_donate.BackColor = System.Drawing.Color.Maroon;
            this.button_donate.Location = new System.Drawing.Point(12, 38);
            this.button_donate.Name = "button_donate";
            this.button_donate.Size = new System.Drawing.Size(86, 41);
            this.button_donate.TabIndex = 21;
            this.button_donate.Text = "I want to donate!";
            this.button_donate.UseVisualStyleBackColor = false;
            this.button_donate.Click += new System.EventHandler(this.iwtd_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Maroon;
            this.information.Location = new System.Drawing.Point(12, 132);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(86, 41);
            this.information.TabIndex = 18;
            this.information.Text = "Information";
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // editpan
            // 
            this.editpan.BackColor = System.Drawing.Color.PeachPuff;
            this.editpan.Controls.Add(this.button_deleteAccount);
            this.editpan.Controls.Add(this.button_updateDonorDetails);
            this.editpan.Controls.Add(this.textBox_updateCNP);
            this.editpan.Controls.Add(this.label9);
            this.editpan.Controls.Add(this.dateOfBirth_update);
            this.editpan.Controls.Add(this.close4);
            this.editpan.Controls.Add(this.textBox_updatePassword);
            this.editpan.Controls.Add(this.textBox_updateUsername);
            this.editpan.Controls.Add(this.textBox_updateLatName);
            this.editpan.Controls.Add(this.textBox_updateFirstName);
            this.editpan.Controls.Add(this.label11);
            this.editpan.Controls.Add(this.label15);
            this.editpan.Controls.Add(this.label16);
            this.editpan.Controls.Add(this.label17);
            this.editpan.Controls.Add(this.label18);
            this.editpan.Location = new System.Drawing.Point(276, 12);
            this.editpan.Name = "editpan";
            this.editpan.Size = new System.Drawing.Size(319, 399);
            this.editpan.TabIndex = 27;
            this.editpan.Visible = false;
            // 
            // button_deleteAccount
            // 
            this.button_deleteAccount.BackColor = System.Drawing.Color.LightSalmon;
            this.button_deleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteAccount.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteAccount.Location = new System.Drawing.Point(3, 344);
            this.button_deleteAccount.Name = "button_deleteAccount";
            this.button_deleteAccount.Size = new System.Drawing.Size(100, 52);
            this.button_deleteAccount.TabIndex = 46;
            this.button_deleteAccount.Text = "Delete account";
            this.button_deleteAccount.UseVisualStyleBackColor = false;
            this.button_deleteAccount.Click += new System.EventHandler(this.button_deleteAccount_Click);
            // 
            // button_updateDonorDetails
            // 
            this.button_updateDonorDetails.BackColor = System.Drawing.Color.LightSalmon;
            this.button_updateDonorDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_updateDonorDetails.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateDonorDetails.Location = new System.Drawing.Point(109, 288);
            this.button_updateDonorDetails.Name = "button_updateDonorDetails";
            this.button_updateDonorDetails.Size = new System.Drawing.Size(100, 34);
            this.button_updateDonorDetails.TabIndex = 45;
            this.button_updateDonorDetails.Text = "EDIT";
            this.button_updateDonorDetails.UseVisualStyleBackColor = false;
            this.button_updateDonorDetails.Click += new System.EventHandler(this.button_updateDonorDetails_Click);
            // 
            // textBox_updateCNP
            // 
            this.textBox_updateCNP.BackColor = System.Drawing.Color.Linen;
            this.textBox_updateCNP.Location = new System.Drawing.Point(109, 152);
            this.textBox_updateCNP.Name = "textBox_updateCNP";
            this.textBox_updateCNP.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateCNP.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "CNP:";
            // 
            // dateOfBirth_update
            // 
            this.dateOfBirth_update.Location = new System.Drawing.Point(109, 102);
            this.dateOfBirth_update.Name = "dateOfBirth_update";
            this.dateOfBirth_update.Size = new System.Drawing.Size(190, 20);
            this.dateOfBirth_update.TabIndex = 42;
            // 
            // close4
            // 
            this.close4.AutoSize = true;
            this.close4.BackColor = System.Drawing.Color.Red;
            this.close4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close4.Location = new System.Drawing.Point(301, 1);
            this.close4.Name = "close4";
            this.close4.Size = new System.Drawing.Size(17, 16);
            this.close4.TabIndex = 41;
            this.close4.Text = "X";
            this.close4.Click += new System.EventHandler(this.close4_Click);
            // 
            // textBox_updatePassword
            // 
            this.textBox_updatePassword.BackColor = System.Drawing.Color.Linen;
            this.textBox_updatePassword.Location = new System.Drawing.Point(109, 247);
            this.textBox_updatePassword.Name = "textBox_updatePassword";
            this.textBox_updatePassword.PasswordChar = '*';
            this.textBox_updatePassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_updatePassword.TabIndex = 33;
            // 
            // textBox_updateUsername
            // 
            this.textBox_updateUsername.BackColor = System.Drawing.Color.Linen;
            this.textBox_updateUsername.Location = new System.Drawing.Point(109, 201);
            this.textBox_updateUsername.Name = "textBox_updateUsername";
            this.textBox_updateUsername.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateUsername.TabIndex = 29;
            // 
            // textBox_updateLatName
            // 
            this.textBox_updateLatName.BackColor = System.Drawing.Color.Linen;
            this.textBox_updateLatName.Location = new System.Drawing.Point(109, 59);
            this.textBox_updateLatName.Name = "textBox_updateLatName";
            this.textBox_updateLatName.Size = new System.Drawing.Size(140, 20);
            this.textBox_updateLatName.TabIndex = 28;
            // 
            // textBox_updateFirstName
            // 
            this.textBox_updateFirstName.BackColor = System.Drawing.Color.Linen;
            this.textBox_updateFirstName.Location = new System.Drawing.Point(109, 21);
            this.textBox_updateFirstName.Name = "textBox_updateFirstName";
            this.textBox_updateFirstName.Size = new System.Drawing.Size(140, 20);
            this.textBox_updateFirstName.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Username:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Birthdate:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "Password:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Last Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 16;
            this.label18.Text = "First Name:";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Tan;
            this.info.Controls.Add(this.label22);
            this.info.Controls.Add(this.close1);
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.webBrowser1);
            this.info.Controls.Add(this.richTextBox1);
            this.info.Controls.Add(this.pictureBox1);
            this.info.Location = new System.Drawing.Point(200, 52);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(504, 380);
            this.info.TabIndex = 25;
            this.info.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label22.Location = new System.Drawing.Point(407, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 18);
            this.label22.TabIndex = 44;
            this.label22.Text = "Video";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // close1
            // 
            this.close1.AutoSize = true;
            this.close1.BackColor = System.Drawing.Color.Red;
            this.close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close1.Location = new System.Drawing.Point(479, 0);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(17, 16);
            this.close1.TabIndex = 43;
            this.close1.Text = "X";
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(-3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is blood?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(294, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blood Types";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(122, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tips for a safe donatin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(470, 341);
            this.webBrowser1.TabIndex = 46;
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/watch?v=CRh_dAzXuoU", System.UriKind.Absolute);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(493, 348);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // panel_donations
            // 
            this.panel_donations.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel_donations.Controls.Add(this.tabControl1);
            this.panel_donations.Controls.Add(this.close3);
            this.panel_donations.Location = new System.Drawing.Point(233, 32);
            this.panel_donations.Name = "panel_donations";
            this.panel_donations.Size = new System.Drawing.Size(421, 361);
            this.panel_donations.TabIndex = 26;
            this.panel_donations.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 326);
            this.tabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_futureDonations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scheduled donations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_futureDonations
            // 
            this.listView_futureDonations.HideSelection = false;
            this.listView_futureDonations.Location = new System.Drawing.Point(5, 3);
            this.listView_futureDonations.MultiSelect = false;
            this.listView_futureDonations.Name = "listView_futureDonations";
            this.listView_futureDonations.Size = new System.Drawing.Size(400, 296);
            this.listView_futureDonations.TabIndex = 0;
            this.listView_futureDonations.UseCompatibleStateImageBehavior = false;
            this.listView_futureDonations.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView_pastDonations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Completed donations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView_pastDonations
            // 
            this.listView_pastDonations.HideSelection = false;
            this.listView_pastDonations.Location = new System.Drawing.Point(4, 3);
            this.listView_pastDonations.Name = "listView_pastDonations";
            this.listView_pastDonations.Size = new System.Drawing.Size(401, 296);
            this.listView_pastDonations.TabIndex = 0;
            this.listView_pastDonations.UseCompatibleStateImageBehavior = false;
            this.listView_pastDonations.View = System.Windows.Forms.View.List;
            // 
            // close3
            // 
            this.close3.AutoSize = true;
            this.close3.BackColor = System.Drawing.Color.Red;
            this.close3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close3.Location = new System.Drawing.Point(401, 2);
            this.close3.Name = "close3";
            this.close3.Size = new System.Drawing.Size(17, 16);
            this.close3.TabIndex = 44;
            this.close3.Text = "X";
            this.close3.Click += new System.EventHandler(this.close3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.label_email);
            this.panel2.Controls.Add(this.label_address);
            this.panel2.Controls.Add(this.label_centerEmail);
            this.panel2.Controls.Add(this.label_centerAddress);
            this.panel2.Controls.Add(this.dateTimePicker_donation);
            this.panel2.Controls.Add(this.comboBox_town);
            this.panel2.Controls.Add(this.label_Town);
            this.panel2.Controls.Add(this.button_scheduleDonation);
            this.panel2.Controls.Add(this.comboBox_county);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.close2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(254, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 395);
            this.panel2.TabIndex = 28;
            this.panel2.Visible = false;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(99, 219);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 61;
            this.label_email.Text = "Email:";
            this.label_email.Visible = false;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(99, 193);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(48, 13);
            this.label_address.TabIndex = 60;
            this.label_address.Text = "Address:";
            this.label_address.Visible = false;
            // 
            // label_centerEmail
            // 
            this.label_centerEmail.AutoSize = true;
            this.label_centerEmail.Location = new System.Drawing.Point(160, 219);
            this.label_centerEmail.Name = "label_centerEmail";
            this.label_centerEmail.Size = new System.Drawing.Size(114, 13);
            this.label_centerEmail.TabIndex = 59;
            this.label_centerEmail.Text = "center email goes here";
            this.label_centerEmail.Visible = false;
            // 
            // label_centerAddress
            // 
            this.label_centerAddress.AutoSize = true;
            this.label_centerAddress.Location = new System.Drawing.Point(160, 193);
            this.label_centerAddress.Name = "label_centerAddress";
            this.label_centerAddress.Size = new System.Drawing.Size(127, 13);
            this.label_centerAddress.TabIndex = 58;
            this.label_centerAddress.Text = "center address goes here";
            this.label_centerAddress.Visible = false;
            // 
            // dateTimePicker_donation
            // 
            this.dateTimePicker_donation.Location = new System.Drawing.Point(91, 255);
            this.dateTimePicker_donation.Name = "dateTimePicker_donation";
            this.dateTimePicker_donation.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_donation.TabIndex = 57;
            this.dateTimePicker_donation.Visible = false;
            this.dateTimePicker_donation.ValueChanged += new System.EventHandler(this.dateTimePicker_donation_ValueChanged);
            // 
            // comboBox_town
            // 
            this.comboBox_town.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_town.FormattingEnabled = true;
            this.comboBox_town.Location = new System.Drawing.Point(146, 140);
            this.comboBox_town.Name = "comboBox_town";
            this.comboBox_town.Size = new System.Drawing.Size(121, 21);
            this.comboBox_town.TabIndex = 56;
            this.comboBox_town.Visible = false;
            this.comboBox_town.SelectedIndexChanged += new System.EventHandler(this.comboBox_town_SelectedIndexChanged);
            // 
            // label_Town
            // 
            this.label_Town.AutoSize = true;
            this.label_Town.Location = new System.Drawing.Point(97, 144);
            this.label_Town.Name = "label_Town";
            this.label_Town.Size = new System.Drawing.Size(37, 13);
            this.label_Town.TabIndex = 55;
            this.label_Town.Text = "Town:";
            this.label_Town.Visible = false;
            // 
            // button_scheduleDonation
            // 
            this.button_scheduleDonation.BackColor = System.Drawing.Color.Moccasin;
            this.button_scheduleDonation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_scheduleDonation.Location = new System.Drawing.Point(157, 337);
            this.button_scheduleDonation.Name = "button_scheduleDonation";
            this.button_scheduleDonation.Size = new System.Drawing.Size(78, 30);
            this.button_scheduleDonation.TabIndex = 53;
            this.button_scheduleDonation.Text = "Schedule";
            this.button_scheduleDonation.UseVisualStyleBackColor = false;
            this.button_scheduleDonation.Visible = false;
            this.button_scheduleDonation.Click += new System.EventHandler(this.button_scheduleDonation_Click);
            // 
            // comboBox_county
            // 
            this.comboBox_county.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_county.FormattingEnabled = true;
            this.comboBox_county.Location = new System.Drawing.Point(146, 113);
            this.comboBox_county.Name = "comboBox_county";
            this.comboBox_county.Size = new System.Drawing.Size(121, 21);
            this.comboBox_county.TabIndex = 51;
            this.comboBox_county.SelectedIndexChanged += new System.EventHandler(this.comboBox_county_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.CadetBlue;
            this.label23.Location = new System.Drawing.Point(52, 76);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(274, 21);
            this.label23.TabIndex = 47;
            this.label23.Text = "Please choose the center and date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(97, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "County:";
            // 
            // close2
            // 
            this.close2.AutoSize = true;
            this.close2.BackColor = System.Drawing.Color.Red;
            this.close2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2.Location = new System.Drawing.Point(369, 0);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(17, 16);
            this.close2.TabIndex = 42;
            this.close2.Text = "X";
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(51, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 28);
            this.label13.TabIndex = 43;
            this.label13.Text = "Thank you for your intention!";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(922, 429);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 13);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "label26";
            this.lbl.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(603, 445);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 31;
            this.label26.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(618, 447);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 32;
            this.label27.Visible = false;
            // 
            // button_editAccount
            // 
            this.button_editAccount.BackColor = System.Drawing.Color.Maroon;
            this.button_editAccount.Location = new System.Drawing.Point(12, 290);
            this.button_editAccount.Name = "button_editAccount";
            this.button_editAccount.Size = new System.Drawing.Size(86, 41);
            this.button_editAccount.TabIndex = 36;
            this.button_editAccount.Text = "Edit Account";
            this.button_editAccount.UseVisualStyleBackColor = false;
            this.button_editAccount.Click += new System.EventHandler(this.button_editAccount_Click);
            // 
            // button_myDonations
            // 
            this.button_myDonations.BackColor = System.Drawing.Color.Maroon;
            this.button_myDonations.Location = new System.Drawing.Point(12, 179);
            this.button_myDonations.Name = "button_myDonations";
            this.button_myDonations.Size = new System.Drawing.Size(86, 41);
            this.button_myDonations.TabIndex = 37;
            this.button_myDonations.Text = "My donations";
            this.button_myDonations.UseVisualStyleBackColor = false;
            this.button_myDonations.Click += new System.EventHandler(this.button_myDonations_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Maroon;
            this.button_logout.Location = new System.Drawing.Point(12, 397);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(86, 41);
            this.button_logout.TabIndex = 38;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editpan);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel_donations);
            this.Controls.Add(this.button_myDonations);
            this.Controls.Add(this.button_editAccount);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_donate);
            this.Controls.Add(this.information);
            this.Controls.Add(this.info);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.editpan.ResumeLayout(false);
            this.editpan.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_donations.ResumeLayout(false);
            this.panel_donations.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label21;
		public System.Windows.Forms.Label label_username;
		private System.Windows.Forms.Button button_donate;
		private System.Windows.Forms.Button information;
		private System.Windows.Forms.Panel editpan;
		private System.Windows.Forms.DateTimePicker dateOfBirth_update;
		private System.Windows.Forms.Label close4;
		private System.Windows.Forms.TextBox textBox_updatePassword;
		private System.Windows.Forms.TextBox textBox_updateUsername;
		private System.Windows.Forms.TextBox textBox_updateLatName;
		private System.Windows.Forms.TextBox textBox_updateFirstName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Panel info;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label close1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox_updateCNP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label close2;
		private System.Windows.Forms.Button button_scheduleDonation;
		private System.Windows.Forms.ComboBox comboBox_county;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox_town;
        private System.Windows.Forms.Label label_Town;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_centerEmail;
        private System.Windows.Forms.Label label_centerAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker_donation;
        private System.Windows.Forms.Panel panel_donations;
        private System.Windows.Forms.Label close3;
        private System.Windows.Forms.Button button_editAccount;
        private System.Windows.Forms.Button button_updateDonorDetails;
        private System.Windows.Forms.Button button_myDonations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_futureDonations;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_pastDonations;
        private System.Windows.Forms.Button button_deleteAccount;
        private System.Windows.Forms.Button button_logout;
    }
}