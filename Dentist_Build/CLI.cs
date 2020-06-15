using System;
using System.Globalization;
namespace Dentist_Build
{
    public static class CLI
    {

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
            CentralisedRecords.SubmitNewPatient(new Patient(surname, firstname, address, dob, number));
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
    }
}
