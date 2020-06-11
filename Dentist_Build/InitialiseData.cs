using System;
namespace Dentist_Build
{
    public static class InitialiseData
    {
        static InitialiseData()
        {
        }

        public static void Initialise()
        {
            Patient patient = new Patient("Jim Shaun", "12 Fake Street, Taunton, TA1 1NN", 07001001002);
        }

    }
}
