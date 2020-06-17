using System;

namespace Dentist_Build
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            InitialiseData.Initialise();




            CLI.CreateNewPatient();
            // CLI.CreateNewStaff();
            CLI.CreateNewAppointment();

            //CentralisedRecords.ShowAllActiveStaff();
            //CentralisedRecords.ShowAllPatientRecords();




        }
    }
}
