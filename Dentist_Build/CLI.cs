using System;
namespace Dentist_Build
{
    public static class CLI
    {
        
            public static void CreateNewPatient()
            {
            Console.WriteLine("     *******************     \nCreating New Patient Record:\n     *******************     \nEnter Patient Full Name:\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Patient Address and Postcode:\n");
            string address = Console.ReadLine();
            Console.WriteLine("\nEnter Patient Primary Contact Number:\n");
            long number = Convert.ToInt64(Console.ReadLine());
            Patient patient = new Patient(name, address, number);
            }

        
    }
}
