using System;
using System.Collections.Generic;
namespace Dentist_Build
{
    public static class CentralisedRecords
    {
        //
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

        //used to assign a patient to a dentist that exists within centralised records
        public static Staff AssignDentist(Practice practice)
        {
            while (true)
            {
                Console.WriteLine("Which Dentist would you like to assign this Patient?\nAvailable Dentists at this Practice:\n");
                Console.WriteLine("Select with numerical input:\n");

                for (int i = 0; i < practice.ActivePracticeStaff.Count; i++)
                {
                    Console.WriteLine("{0}: Dr. {1}", i, practice.ActivePracticeStaff[i].Surname);
                }
                int choice = Convert.ToInt16(Console.ReadLine());

                return practice.ActivePracticeStaff[choice];
            }
        }

        //used to assign a patient with 
        public static Practice AssignPractice()
        {
            Console.WriteLine("Which Practice will this patient access?");
            string location = Console.ReadLine();
            while (true)
            {
                for (int i = 0; i < PracticeDirectory.Count; i++)
                {
                    if (PracticeDirectory[i].location.Equals(location))
                    {
                        return PracticeDirectory[i].GetData();

                    }
                }

                Console.WriteLine("!!! Warning Practice Not Found !!!\n*****Please Retype Practice Name****\n");
                location = Console.ReadLine();
            }
        }

        public static Patient SearchPatientRecords(string parameter)
        {
            while (true)
            {
                foreach (Patient patient in PatientRecordsDatabase)
                {
                    if (patient.Surname.Equals(parameter))
                    {
                        return patient;
                    }

                }
                Console.WriteLine("!!! Warning Patient Not Found !!!\n*****Please Retype Practice Name****\n");
                parameter = Console.ReadLine();
            }
        }


        public static Staff SearchStaffRecords(string username)
        {
            while (true)
            {
                foreach (Staff staffmember in StaffListRecords)
                {
                    if (staffmember.username.Equals(username))
                    {
                        return staffmember;
                    }

                }
                Console.WriteLine("!!! Warning Staff Username Not Recognised !!!\n*****Please Retype Username****\n");
                username = Console.ReadLine();
            }
        }

        public static void ShowAllPatientRecords()
        {
            foreach (Patient patient in PatientRecordsDatabase)
            {
                Console.WriteLine("Patient Record Details:\nSurname: {0}\nFirst Name: {1}\nAddress: " +
                    "{2}\nContact Number: {3}\nDate of Birth: {4}\nAssigned Dentist: {5}\n\nEnd of Patient Record\n\n", patient.Surname, patient.FirstName, patient.Address, patient.contactnumber, patient.Dob.ToString("dd/MM/yy"), patient.GetDentist());

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
