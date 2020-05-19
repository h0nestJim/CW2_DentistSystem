using System;

namespace Dentist_Build
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Patient patient1 = new Patient("Jim", "Taunton");

            patient1.Introduce();
        }
    }
}
