using System;

namespace Dentist_Build
{
    class Program
    {
        static void Main(string[] args)
        {

            InitialiseData.Initialise();

            //CLI.CreateNewPatient();
            // CLI.CreateNewStaff();

            CentralisedRecords.ShowAllActiveStaff();
            //CentralisedRecords.ShowAllPatientRecords();




        }
    }
}
