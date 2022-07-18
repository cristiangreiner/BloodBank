using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }

    class Doctor
    {
        public User User { get; set; }
        public string DocID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CenterID { get; set; }
        public Doctor(User User) 
        {
            this.User = User;
            this.DocID = "";
            this.FirstName = "";
            this.LastName = "";
            this.CenterID = -1;
        }
        public Doctor()
        { }
    }

    class Donor
    {
        public User User { get; set; }
        public string DonorID { get; set; }
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public Donor(User User)
        {
            this.User = User;
            this.DonorID = "";
            this.CNP = "";
            this.FirstName = "";
            this.LastName = "";
            this.DOB = "";
        }
        public Donor()
        { }
    }

}
