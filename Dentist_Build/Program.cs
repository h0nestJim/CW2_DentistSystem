using System;

namespace Dentist_Build
{
    class Program
    {
        static void Main(string[] args)
        {

            InitialiseData.Initialise();
            
            CLI.CreateNewPatient();
            
            PatientRecords.ShowAllRecords();


           

        }
    }
}
