using System;
using System.Collections.Generic;

namespace Dentist_Build
{
    public static class PatientRecords
    {

        private static List<Patient> PatientRecordsDatabase = new List<Patient>();

        public static void SubmitNewPatient(Patient patient)
        {
            PatientRecordsDatabase.Add(patient);
        }

        public static void SearchRecords()
        {
            //script to search records/Patient List
        }

        public static void ShowAllRecords()
        {
            foreach (Patient patient in PatientRecordsDatabase){
                Console.WriteLine("Patient Record Details:\nFull Name: {0}\nAddress: " +
                    "{1}\nContact Number: {2}\n\nEnd of Patient Record\n\n", patient.Name, patient.Address, patient.number.ToString());

            }
        }


    }
}
