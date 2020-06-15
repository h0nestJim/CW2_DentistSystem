using System;
using System.Collections.Generic;
namespace Dentist_Build
{
    public static class CentralisedRecords
    {
        private static List<Patient> PatientRecordsDatabase = new List<Patient>();
        private static List<Staff> StaffListRecords = new List<Staff>();
        private static List<Practice> PracticeDirectory = new List<Practice>();

        //Staff and Patient Lists for inactive patients or retired/resigned staff members
        private static List<Patient> LegacyPatientRecordsDatabase = new List<Patient>();
        private static List<Staff> LegacyStaffList = new List<Staff>();

        //Submits new patients to the central patient list
        public static void SubmitNewPatient(Patient patient)
        {
            PatientRecordsDatabase.Add(patient);
        }

        //Submits new staff to the central staff list
        public static void SubmitNewStaff(Staff staff)
        {
            StaffListRecords.Add(staff);
        }

        public static void InitialiseNewPractice(Practice practice)
        {
            PracticeDirectory.Add(practice);
        }

        public static Practice FindPractice(string locationSearch)
        {
            while (true)
            {
                for (int i = 0; i < PracticeDirectory.Count; i++)
                {
                    if (PracticeDirectory[i].location.Equals(locationSearch))
                    {
                        return PracticeDirectory[i].GetData();

                    }
                }

                Console.WriteLine("!!! Warning Practice Not Found !!!\n*****Please Retype Practice Name****\n");
                locationSearch = Console.ReadLine();
            }


        }

        public static void SearchPatientRecords()
        {
            //script to search records/Patient List
        }
        public static void SearchStaffRecords()
        {
            //script to search records/Patient List
        }

        public static void ShowAllPatientRecords()
        {
            foreach (Patient patient in PatientRecordsDatabase)
            {
                Console.WriteLine("Patient Record Details:\nSurname: {0}\nFirst Name: {1}\nAddress: " +
                    "{2}\nContact Number: {3}\n\nEnd of Patient Record\n\n", patient.FirstName, patient.Surname, patient.Address, patient.Dob.ToString("dd/MM/yy"), patient.contactnumber);

            }
        }

        public static void ShowAllActiveStaff()
        {
            foreach (Staff staff in StaffListRecords)
            {
                Console.WriteLine("Staff Record Details:\nSurname: {0}\nFirst Name: {1}\nAddress: " +
                    "{2}\nDate of Birth: {3}\nContact Number: {4}\nAssigned Practice: {5}\n\nEnd of Staff Record\n\n", staff.Surname, staff.FirstName,
                        staff.Address, staff.Dob.ToString("dd/MM/yy"), staff.ContactNumber, staff.practice.location);


            }
        }

    }
}
