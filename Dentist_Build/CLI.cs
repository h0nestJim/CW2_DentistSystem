using System;
using System.Globalization;
namespace Dentist_Build
{
    public static class CLI
    {
        public static void Start()
        {
            //demand login and call authenticator
        }


        public static void Menu()
        {
            //show menu for staff type
        }



        public static void CreateNewPatient()
        {
            Console.WriteLine("     *******************     \nCreating New Patient Record:\n     *******************     \nEnter Patient Surname:\n");
            string surname = Console.ReadLine();
            Console.WriteLine("\nEnter Patient First Name:\n");
            string firstname = Console.ReadLine();
            Console.WriteLine("\nEnter Patient Date of Birth in the format [DD/MM/YY]:\n");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Patient Address and Postcode:\n");
            string address = Console.ReadLine();
            Console.WriteLine("\nEnter Patient Primary Contact Number:\n");
            long number = Convert.ToInt64(Console.ReadLine());
            CentralisedRecords.SubmitNewPatient(new Patient(firstname, surname, address, dob, number));
        }

        public static void CreateNewStaff()
        {
            Console.WriteLine("     *******************     \nCreating New Staff Record:\n     *******************     \nEnter Staff Surname:\n");
            string surname = Console.ReadLine();
            Console.WriteLine("\nEnter Staff First Name:\n");
            string firstname = Console.ReadLine();
            Console.WriteLine("\nEnter Staff Date of Birth in the format [DD/MM/YY]:\n");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Staff Address and Postcode:\n");
            string address = Console.ReadLine();
            Console.WriteLine("\nEnter Staff Primary Contact Number:\n");
            long number = Convert.ToInt64(Console.ReadLine());

            //Start Method call to identify and find the practice
            Console.WriteLine("\nWhich Practice is Staff member's princple Practice\n");
            string location = Console.ReadLine();



            CentralisedRecords.SubmitNewStaff(new Staff(firstname, surname, address, dob, number, Role.Nurse, CentralisedRecords.FindPractice(location)));



        }

        public static void CreateNewAppointment()
        {
            Console.WriteLine("Enter Surname name to begin creating new appointment");
            string name = Console.ReadLine();
            Patient ex = CentralisedRecords.SearchPatientRecords(name);
            Console.WriteLine("Patient Found: {0} {1}\nDoB: {2}", ex.FirstName, ex.Surname, ex.Dob.ToString("dd/MM/yy"));
            Console.WriteLine("Enter Date of Appointment in format DD/MM/YY: ");
            string date = Console.ReadLine();
            Console.WriteLine("Enter Time of Appointment in format: HH:MM in 24-hour clock");
            string time = Console.ReadLine();
            DateTime appdate = DateTime.Parse(date + " " + time);
            Console.WriteLine(appdate.ToString("dd/MM/yy HH:mm"));

            Console.WriteLine("Why is appointment requested? i.e. Annual Check Up");
            string note = Console.ReadLine();

            Console.WriteLine("Input treatment Band:/n1: Band 1\n2: Band 2\n3: Band 3");
            Treatment band = (Treatment)Convert.ToInt16(Console.ReadLine()) - 1;

            Console.WriteLine(band);

            ex.practice.SubmitAppointment(new Appointment(ex, appdate, ex.GetDentistObj(), band, note));

        }

        public static void AddPatientNotes()
        {

        }


    }
}
