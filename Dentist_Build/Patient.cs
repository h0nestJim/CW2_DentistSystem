using System;
using System.Collections.Generic;
namespace Dentist_Build
{
    public class Patient : User
    {

        public long contactnumber;
        private List<string> patientNotes = new List<string>();


        public Patient(string FirstName, string Surname, string Address, DateTime DOB, long num) : base(FirstName, Surname, Address, DOB)
        {
            this.contactnumber = num;

            CentralisedRecords.SubmitNewPatient(this);
        }

        public override void ShowRecord()
        {
            Console.WriteLine("Patient Record Details:\nSurname: {0}\nFirst Name: {1}\nDoB: {2}\nAddress: {3}\nContact Number: {4}\n\nEnd of Patient Record\n\n", Surname, FirstName, Dob.ToString("dd/MM/yy"), Address, contactnumber.ToString());
        }
    }
}
