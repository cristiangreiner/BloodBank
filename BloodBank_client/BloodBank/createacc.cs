using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;

namespace BloodBank
{
    public partial class createacc : Form
    {
        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        bool doctorRadioButtonPrevCheck = false;
        
        public createacc()
        {
            InitializeComponent();
        }

  
        private void doctor_CheckedChanged(object sender, EventArgs e)
        {
            doctorRadioButtonPrevCheck = !(doctorRadioButtonPrevCheck);
            if (doctorRadioButtonPrevCheck)
            {
                textBox_detail.Visible = true;
                label_youTicked.Visible = true;
                label_DOB.Visible = false;
                dateTimePicker_donor.Visible = false;
                label_info.Visible = true;
                label_youTicked.Text = "You ticked doctor. Please enter secret code:"; //it's doc123
                label_info.Text = "Secret code:";
            }
            else 
            {
                textBox_detail.Visible = true;
                label_youTicked.Visible = true;
                label_DOB.Visible = true;
                dateTimePicker_donor.Visible = true;
                label_info.Visible = true;
                label_youTicked.Text = "You ticked donor. Please enter personal info:";
                label_info.Text = "CNP:";               
            }

        }

        private void radioButton_donor_CheckedChanged(object sender, EventArgs e)
        {
            textBox_detail.Visible = true;
            label_youTicked.Visible = true;
            label_DOB.Visible = true;
            dateTimePicker_donor.Visible = true;
            label_info.Visible = true;
            label_youTicked.Text = "You ticked donor. Please enter personal info:";
            label_info.Text = "CNP:";
        }

        private void done_Click(object sender, EventArgs e)
        {
         
            if (textBox_usernameAccount.TextLength < 6)
            {
                textBox_usernameAccount.ForeColor = Color.Red;
                textBox_passwordAccount.ForeColor = Color.Black;
                dateTimePicker_donor.CalendarForeColor = Color.Black;
                MessageBox.Show("Username must be at least 6 characters long!");
            }
            else if (textBox_passwordAccount.TextLength < 6)
            {
                textBox_usernameAccount.ForeColor = Color.Black;
                textBox_passwordAccount.ForeColor = Color.Red;
                dateTimePicker_donor.CalendarForeColor = Color.Black;
                MessageBox.Show("Password must be at least 6 characters long!");
            }
            else
            {
                if (radioButton_doctor.Checked == true)
                {
                    string message = service.addUser(textBox_usernameAccount.Text, textBox_passwordAccount.Text, 
                        "doctor", textBox_detail.Text, null, null, textBox_firstNameAccount.Text, textBox_lastNameAccount.Text);
                    MessageBox.Show(message);
                    if(message.Equals("Account created successfully")) //close this tab and open back the login form
                    {
                        this.Close();
                        Thread thread = new Thread(openLoginForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                }
                else if (radioButton_donor.Checked == true) 
                {
                    string message = service.addUser(textBox_usernameAccount.Text, textBox_passwordAccount.Text,
                          "donor", null, textBox_detail.Text, dateTimePicker_donor.Value.ToString("d"), textBox_firstNameAccount.Text, textBox_lastNameAccount.Text);
                    MessageBox.Show(message);
                    if (message.Equals("Account created successfully")) //close this tab and open back the login form
                    {
                        this.Close();
                        Thread thread = new Thread(openLoginForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }'An error occurred while receiving the HTTP response to https://localhost:44356/WebService1.asmx. This could be due to the service endpoint binding not using the HTTP protocol. This could also be due to an HTTP request context being aborted by the server (possibly due to the service shutting down). See server logs for 
                }
            }
        }

        private void openLoginForm()
        {
            Application.Run(new Main());
        }

       
    }
	
}
