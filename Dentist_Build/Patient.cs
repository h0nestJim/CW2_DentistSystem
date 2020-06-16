using System;
using System.Collections.Generic;
namespace Dentist_Build
{
    public class Patient : User
    {

        public long contactnumber;
        private Staff assignedDentist;
        private Practice practice;
        private List<string> patientNotes = new List<string>();

        //Constructor used to create new Patient during software operation
        public Patient(string FirstName, string Surname, string Address, DateTime DOB, long num) : base(FirstName, Surname, Address, DOB)
        {
            this.contactnumber = num;
            this.practice = CentralisedRecords.AssignPractice();
            this.assignedDentist = CentralisedRecords.AssignDentist(practice);
            CentralisedRecords.SubmitNewPatient(this);
        }

        //Constructor used to initialise dummy data without manual assignment of dentist and practice
        public Patient(string FirstName, string Surname, string Address, DateTime DOB, long num, Practice Practice, Staff AssignedDentist) : base(FirstName, Surname, Address, DOB)
        {
            this.contactnumber = num;
            this.practice = Practice;
            this.assignedDentist = AssignedDentist;
            CentralisedRecords.SubmitNewPatient(this);
        }

        public override void ShowRecord()
        {
            Console.WriteLine("Patient Record Details:\nSurname: {0}\nFirst Name: {1}\nDoB: {2}\nAddress: {3}\nContact Number: {4}\n\nEnd of Patient Record\n\n", Surname, FirstName, Dob.ToString("dd/MM/yy"), Address, contactnumber.ToString());
        }

        public string GetDentist()
        {
            return assignedDentist.Surname;
        }
    }
}
