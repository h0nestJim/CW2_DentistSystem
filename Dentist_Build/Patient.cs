using System;
namespace Dentist_Build
{
    public class Patient : User
    {

        public long number;


        public Patient(string Name, string Address, long num) : base(Name, Address)
        {
            this.number = num;
            PatientRecords.SubmitNewPatient(this);
        }

        public override void ShowRecord()
        {
            Console.WriteLine("Patient Record Details:\nFull Name: {0}\nAddress: {1}\nContact Number: {2}\n\nEnd of Patient Record\n\n", Name, Address, number.ToString());
        }
    }
}
