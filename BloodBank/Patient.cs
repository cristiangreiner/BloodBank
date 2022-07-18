using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace BloodBank
{
	public partial class Patient : Form
	{
        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        Donor donor = new Donor();

        public Patient(User user)
		{
			InitializeComponent();

            donor.User = user;
            donor.DonorID = service.getDonorID(user.Username);
            donor.CNP = service.getDonorCNP(donor.DonorID);
            donor.FirstName = service.getDonorFirstName(donor.DonorID);
            donor.LastName = service.getDonorLastName(donor.DonorID);
            donor.DOB = service.getDonorDOB(donor.DonorID);

            label_username.Text = user.Username;

            List<string> counties = service.getCenterCountyList();
            foreach(string county in counties)
            {
                comboBox_county.Items.Add(county);
            }
        
        }

        private void comboBox_county_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_town.Items.Clear();
            comboBox_town.ResetText();
            label_address.Visible = false;
            label_centerAddress.Visible = false;
            label_email.Visible = false;
            label_centerEmail.Visible = false;
            dateTimePicker_donation.Visible = false;
            button_scheduleDonation.Visible = false;


            label_Town.Visible = true;
            comboBox_town.Visible = true;
            string selectedCounty = comboBox_county.SelectedItem.ToString();
            List<string> towns = service.getCenterTownList(selectedCounty);
            foreach(string town in towns) 
            {
                comboBox_town.Items.Add(town);
            }
        }

        private void comboBox_town_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_address.Visible = true;
            label_centerAddress.Visible = true;
            label_email.Visible = true;
            label_centerEmail.Visible = true;
            dateTimePicker_donation.Visible = true;

            string selectedTown = comboBox_town.SelectedItem.ToString();
            label_centerAddress.Text = service.getCenterAddress(selectedTown);
            label_centerEmail.Text = service.getCenterEmail(selectedTown);

        }

        private void dateTimePicker_donation_ValueChanged(object sender, EventArgs e)
        {
            button_scheduleDonation.Visible = true;
        }

        private void button_scheduleDonation_Click(object sender, EventArgs e)
        {
            string selectedCounty = comboBox_county.SelectedItem.ToString();
            string selectedTown = comboBox_town.SelectedItem.ToString();
            string selectedDate = dateTimePicker_donation.Value.ToString("d");
            string selectedCenterID = service.getCenterID(selectedTown);

            string message = service.addDonation(donor.DonorID, selectedCenterID, selectedDate);
            MessageBox.Show(message);

            label_Town.Visible = false;
            comboBox_town.Visible = false;
            label_address.Visible = false;
            label_centerAddress.Visible = false;
            label_email.Visible = false;
            label_centerEmail.Visible = false;
            dateTimePicker_donation.Visible = false;
            button_scheduleDonation.Visible = false;
            panel2.Visible = false;
        }

        // i want to donate
        private void iwtd_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel_donations.Visible = false;
            info.Visible = false;
            editpan.Visible = false;
            dateTimePicker_donation.MinDate = DateTime.Now;
        }  

        private void close2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

       
        private void information_Click(object sender, EventArgs e)
        {
            info.Visible = true;
            panel2.Visible = false;
            panel_donations.Visible = false;
            editpan.Visible = false;

            pictureBox1.Visible = false;
            richTextBox1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("whatisblood.txt");
            pictureBox1.Visible = false;
            richTextBox1.Visible = true;
            webBrowser1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            richTextBox1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = File.ReadAllText("donate.txt");
            pictureBox1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            pictureBox1.Visible = false;
            richTextBox1.Visible = false;
        }

        private void close1_Click(object sender, EventArgs e)
        {
            info.Visible = false;
        }

        private void county_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Town.Visible = true;
            comboBox_town.Visible = true;
            comboBox_town.Items.Clear();
        }

        private void close3_Click(object sender, EventArgs e)
        {
            panel_donations.Visible = false;
        }

        private void close4_Click(object sender, EventArgs e)
        {
            editpan.Visible = false;
        }

        private void button_editAccount_Click(object sender, EventArgs e)
        {
            panel_donations.Visible = false;
            info.Visible = false;
            panel2.Visible = false;
            editpan.Visible = true;

            dateOfBirth_update.MaxDate = DateTime.Now;

            textBox_updateFirstName.Text = donor.FirstName;
            textBox_updateLatName.Text = donor.LastName;
            dateOfBirth_update.Value = DateTime.Parse(donor.DOB);
            textBox_updateCNP.Text = donor.CNP;
            textBox_updateUsername.Text = donor.User.Username;
            textBox_updatePassword.Text = donor.User.Password;
        }

        private void button_updateDonorDetails_Click(object sender, EventArgs e)
        {
            string newUsername = textBox_updateUsername.Text;
            string newPassword = textBox_updatePassword.Text;
            string newFirstName = textBox_updateFirstName.Text;
            string newLastName = textBox_updateLatName.Text;
            string newDOB = dateOfBirth_update.Value.ToString("d");
            string newCNP = textBox_updateCNP.Text;

            if (newUsername.Length < 6 || newPassword.Length < 6) MessageBox.Show("Username/Password must have at least 6 characters");
            else
            {
                if (newFirstName != donor.FirstName || newLastName != donor.LastName)
                {
                    string message = service.updateDonorDetails(donor.DonorID,newCNP,newFirstName,newLastName,newDOB);
                    MessageBox.Show("Personal info: " + message);
                    if (message.Equals("Account updated successfully"))
                    {
                        donor.FirstName = newFirstName;
                        donor.LastName = newLastName;
                        donor.CNP = newCNP;
                        donor.DOB = newDOB;
                    }
                }
                if (newPassword != donor.User.Password)
                {
                    string message = service.updateUserPassword(donor.User.Username, newPassword);
                    MessageBox.Show("Password: " + message);
                    if (message.Equals("Account updated successfully"))
                    {
                        donor.User.Password = newPassword;
                    }
                }
                if (newUsername != donor.User.Username)
                {
                    string message = service.updateUserUsername(donor.User.Username, newUsername);
                    MessageBox.Show("Username: " + message);
                    if (message.Equals("Account updated successfully"))
                    {
                        donor.User.Username= newUsername;
                        label_username.Text = newUsername;
                    }
                }
            }
        }

        private void button_myDonations_Click(object sender, EventArgs e)
        {
            info.Visible = false;
            panel2.Visible = false;
            editpan.Visible = false;
            panel_donations.Visible = true;

            List<string> futureDonations = service.getUserFutureDonations(donor.DonorID);
            List<string> pastDonations = service.getUserPastDonations(donor.DonorID);

            listView_futureDonations.Items.Clear();
            listView_pastDonations.Items.Clear();

            foreach(string donation in futureDonations)
            {
                listView_futureDonations.Items.Add(donation);
            }

            foreach (string donation in pastDonations)
            {
                listView_pastDonations.Items.Add(donation);
            }

           
        }

        private void openLoginForm()
        {
            Application.Run(new Main());
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Thread thread = new Thread(openLoginForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void button_deleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account? \n " +
                "This action cannot be reversed", "Delete account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                service.deleteUser(donor.User.Username);
                this.Close();
                Thread thread = new Thread(openLoginForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }
}
