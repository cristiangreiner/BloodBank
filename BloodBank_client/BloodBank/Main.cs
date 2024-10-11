using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BloodBank
{
	public partial class Main : Form
	{
		ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

		public Main()
		{
			InitializeComponent();		
		}
		//login//

		private void button_login_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_usernameLogin.Text != "" && textBox_passwordLogin.Text != "")
				{
					User user = new User(textBox_usernameLogin.Text, textBox_passwordLogin.Text);
					string check = service.login(user.Username, user.Password);
					if (check.Equals("false")) 
						MessageBox.Show("Invalid username/password");
					else
					{
						if (check == "doctor")
						{
							this.Close();
							Thread thread = new Thread(() => openDocForm(user));
							thread.SetApartmentState(ApartmentState.STA);
							thread.Start();
						}
						else if (check == "donor")
						{
							this.Close();
							Thread thread = new Thread(() => openDonorForm(user));
							thread.SetApartmentState(ApartmentState.STA);
							thread.Start();
						}
					}
				}
			} catch
            {
				MessageBox.Show("Server is not responding");
            }
		}

		private void createacc_Click(object sender, EventArgs e)
		{
			this.Close();
			Thread thread = new Thread(openCreateAccount);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void openCreateAccount()
		{
			Application.Run(new createacc());
		}

		private void openDocForm(User user)
		{
			Application.Run(new Doc(user));
		}

		private void openDonorForm(User user)
		{
			Application.Run(new Patient(user));
		}

       
    }

}
