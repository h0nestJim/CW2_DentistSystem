using System;
namespace Dentist_Build
{
    public abstract class User
    {

        private string name;
        private string address;

        public User(string n, string a)
        {
            Name = n;
            address = a;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public abstract void ShowRecord();
        
    }


 
}
