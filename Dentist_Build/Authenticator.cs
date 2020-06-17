using System;
namespace Dentist_Build
{
    public static class Authenticator
    {
        public static void Authenticate(string username, string password)
        {
            Staff user = CentralisedRecords.SearchStaffRecords(username);

            while (!user.CheckPassword(password))
            {
                Console.WriteLine("\nPassword Incorrect! Please Re-enter password!\n");
                password = Console.ReadLine();
            }

            if (password == "0000")
            {
                user.SetNewPassword();
            }

            Console.WriteLine("Login Successful! Welcome {0}!\nRedirecting to Main Menu!");

            switch (user.jobTitle)
            {
                case Role.Admin:
                    {
                        CLI.SysAdminMenu();
                        break;
                    }

                case Role.Dentist:
                    {
                        CLI.DentistMenu();
                        break;
                    }
                case Role.Nurse:
                    {
                        CLI.NurseMenu();
                        break;
                    }
                case Role.Receptionist:
                    {
                        CLI.ReceptionistMenu();
                        break;
                    }
                default: break;
            }


        }
    }
}
