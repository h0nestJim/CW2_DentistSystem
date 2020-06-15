using System;
namespace Dentist_Build
{
    public abstract class User
    {

        private string firstname;
        private string surname;
        private string address;
        private DateTime dob;


        public User(string FirstName, string Surname, string Address, DateTime DOB)
        {
            this.firstname = FirstName;
            this.surname = Surname;
            this.address = Address;
            this.Dob = DOB;
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime Dob {
            get => dob;
            set => dob = value;
        }

        public abstract void ShowRecord();
        
    }


 
}
