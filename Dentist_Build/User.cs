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


        public abstract void Introduce();
        
    }



    public class Patient : User
    {
        public Patient(string Name, string Address) : base(Name, Address)
        {
        }

        public override void Introduce()
        {
            Console.WriteLine("Hello, I am {0}, I live at {1}", Name, Address);
        }
    }
}
