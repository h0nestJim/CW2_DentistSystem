using System;
namespace Dentist_Build
{

    public enum Role
    {
        Admin,
        Dentist,
        Nurse,
        Secretary
    }

    public class Staff : User
    {

        private string username;
        private string password;
        public string emailAddress;
        private long contactNumber;
        public Role jobTitle;
        public Practice practice;


        public long ContactNumber { get => contactNumber; set => contactNumber = value; }

        public Staff(string FirstName, string Surname, string Address, DateTime DOB, long num, Role JobTitle, Practice Practice) : base(FirstName, Surname, Address, DOB)
        {
            this.contactNumber = num;
            this.jobTitle = JobTitle;
            this.practice = Practice;
            GenerateCredentials();
            CentralisedRecords.SubmitNewStaff(this);

        }

        private void GenerateCredentials()
        {
            this.username = Surname + FirstName[0];
            this.password = "0000";
            this.emailAddress = username + "@mydentist.nhs.uk";
        }


        public override void ShowRecord()
        {
            Console.WriteLine("Staff Record Details:\nSurname: {0}\nFirst Name: {1}\nUserName: {2}\nEmail Address: {3}\nRole: " +
                "{4}\n\n\n************\nEnd of Record\n************\n", Surname, FirstName, username, emailAddress, jobTitle);
        }


    }
}
