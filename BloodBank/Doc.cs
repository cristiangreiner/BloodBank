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
	public partial class Doc : Form
	{
		ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
		Doctor doctor = new Doctor();

		public Doc(User user)
		{
			InitializeComponent();

			doctor.User = user;
			doctor.DocID = service.getDoctorID(doctor.User.Username);
			doctor.FirstName = service.getDoctorFirstName(doctor.DocID);
			doctor.LastName = service.getDoctorLastName(doctor.DocID);

			if (service.getDoctorCenterID(doctor.DocID) != "No center selected")
			{
				doctor.CenterID = Int32.Parse(service.getDoctorCenterID(doctor.DocID));
				label_selectedCenter.Text = service.getCenterCity(doctor.CenterID);
			}
			else
			{
				doctor.CenterID = -1;
				label_selectedCenter.Text = "No center selected";
			}
			label_username.Text = doctor.User.Username;

			List<string> counties = service.getCenterCountyList();
			foreach (string county in counties)
			{
				comboBox_county.Items.Add(county);
				comboBox_county2.Items.Add(county);
			}
		}

		// check resources
		private void button1_Click(object sender, EventArgs e)
		{
			panel_check.Visible = true;
			panel_add.Visible = false;
			panel_edit.Visible = false;
			panel_changeCenter.Visible = false;
			comboBox_town.Enabled = false;			
		}

		private void county_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox_town.Enabled = true;
			comboBox_town.Items.Clear();
			comboBox_town.ResetText();
			string selectedCounty = comboBox_county.SelectedItem.ToString();

			List<string> towns = service.getCenterTownList(selectedCounty);
			foreach (string town in towns)
			{
				comboBox_town.Items.Add(town);
			}
		}

		private void city_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedCity = comboBox_town.SelectedItem.ToString();
			string centerID = service.getCenterID(selectedCity);
			listBox_pastDonations.Items.Clear();
			List<string> donations = service.getCenterPastDonations(centerID);
			foreach (string donation in donations)
			{
				listBox_pastDonations.Items.Add(donation);
			}
		}

		private void close1_Click(object sender, EventArgs e)
		{
			panel_check.Visible = false;
		}


        private void label6_Click(object sender, EventArgs e)
		{
			panel_add.Visible = false;
		}

		// edit account

		private void button4_Click(object sender, EventArgs e)
		{
			panel_check.Visible = false;
			panel_add.Visible = false;
			panel_changeCenter.Visible = false;
			panel_edit.Visible = true;

			textBox_firstNameUpdate.Text = doctor.FirstName;
			textBox_lastNameUpdate.Text = doctor.LastName;
			textBox_usernameUpdate.Text = doctor.User.Username;
			textBox_passwordUpdate.Text = doctor.User.Password;
		}

		private void edit_Click_1(object sender, EventArgs e)
		{
			string newFirstName = textBox_firstNameUpdate.Text;
			string newLastName = textBox_lastNameUpdate.Text;
			string newUsername = textBox_usernameUpdate.Text;
			string newPassword = textBox_passwordUpdate.Text;

			if (newUsername.Length < 6 || newPassword.Length < 6) MessageBox.Show("Username/Password must have at least 6 characters");
            else
            {
				if (newFirstName != doctor.FirstName || newLastName != doctor.LastName)
				{
					string message = service.updateDoctorDetails(doctor.DocID, newFirstName, newLastName, doctor.CenterID);
					MessageBox.Show("Personal info: " + message);
					if(message.Equals("Account updated successfully"))
                    {
						doctor.FirstName = newFirstName;
						doctor.LastName = newLastName;
                    }
				}
				if (newPassword != doctor.User.Password)
                {
					string message = service.updateUserPassword(doctor.User.Username, newPassword);
					MessageBox.Show("Password: " + message);
					if (message.Equals("Account updated successfully"))
					{
						doctor.User.Password = newPassword;
					}
				}
				if(newUsername != doctor.User.Username)
                {
					string message = service.updateUserUsername(doctor.User.Username, newUsername);
					MessageBox.Show("Username: " + message);
					if (message.Equals("Account updated successfully"))
					{
						doctor.User.Username = newUsername;
						label_username.Text = newUsername;
					}
				}
            }
		}

		private void close4_Click(object sender, EventArgs e)
		{
			panel_edit.Visible = false;
		}

        private void button_addResources_Click(object sender, EventArgs e)
        {
			panel_check.Visible = false;
			panel_changeCenter.Visible = false;
			panel_edit.Visible = false;
			panel_add.Visible = true;
			button_addDonation.Enabled = false;
			comboBox_bloodType.Enabled = false;

			listBox_futureDonations.Items.Clear();
			List<string> donations = service.getCenterFutureDonations(doctor.CenterID.ToString());
			foreach(string donation in donations)
            {
				listBox_futureDonations.Items.Add(donation);
            }
		}

		private void listBox_futureDonations_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox_bloodType.Enabled = true;
		}

		private void comboBox_bloodType_SelectedIndexChanged(object sender, EventArgs e)
		{
			button_addDonation.Enabled = true;
		}

		private void button_addDonation_Click(object sender, EventArgs e)
		{
			string donationID = listBox_futureDonations.SelectedItem.ToString().Substring(4, 9); // Improvizatie romaneasca!!!
			string message = service.completeDonation(donationID, doctor.DocID, comboBox_bloodType.SelectedItem.ToString());
			MessageBox.Show(message);
			panel_add.Visible = false;
		}

		private void close2_Click(object sender, EventArgs e)
        {
			panel_changeCenter.Visible = false;
        }

		private void button_changeCenter_Click(object sender, EventArgs e)
        {
			label_changeCity.Visible = false;
			comboBox_city2.Visible = false;
			button_selectCenter.Visible = false;
			panel_add.Visible = false;
			panel_check.Visible = false;
			panel_edit.Visible = false;
			panel_changeCenter.Visible = true;
        }

        private void comboBox_county2_SelectedIndexChanged(object sender, EventArgs e)
        {
			comboBox_city2.Items.Clear();
			comboBox_city2.ResetText();
			button_selectCenter.Visible = false;
			label_changeCity.Visible = true;
			comboBox_city2.Visible = true;

			string selectedCounty = comboBox_county2.SelectedItem.ToString();
			List<string> towns = service.getCenterTownList(selectedCounty);
			foreach (string town in towns)
			{
				comboBox_city2.Items.Add(town);
			}

		}

        private void comboBox_city2_SelectedIndexChanged(object sender, EventArgs e)
        {
			button_selectCenter.Visible = true;
        }

        private void button_selectCenter_Click(object sender, EventArgs e)
        {
			string newCenterTown = comboBox_city2.SelectedItem.ToString();
			int newCenterID = Int32.Parse(service.getCenterID(newCenterTown));
			string message = service.updateDoctorDetails(doctor.DocID, doctor.FirstName, doctor.LastName, newCenterID);
			MessageBox.Show(message);

			doctor.CenterID = newCenterID;
			label_selectedCenter.Text = service.getCenterCity(newCenterID);

			panel_changeCenter.Visible = false;
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
				service.deleteUser(doctor.User.Username);
				this.Close();
				Thread thread = new Thread(openLoginForm);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
		}

        private void Doc_Load(object sender, EventArgs e)
        {

        }
    }
}
