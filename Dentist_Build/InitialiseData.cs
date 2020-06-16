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

            //Initialise Practice
            CentralisedRecords.InitialiseNewPractice(new Practice("Taunton"));
            CentralisedRecords.InitialiseNewPractice(new Practice("Bridgwater"));
            CentralisedRecords.InitialiseNewPractice(new Practice("Exeter"));


            //Initialise Patient Records
            Patient Shaunj = new Patient("Shaun", "Jim", "12 Fake Street, Taunton, TA1 1NN", new DateTime(27 / 10 / 1989), 07001001002);

            //Initialise Staff Records

            Staff Sansom = new Staff("Elizabeth", "Sansom", "3 Cyril Street, Taunton, TA2 6HW",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Taunton"));
            Staff Shaun = new Staff("Duncan", "Shaun", "7 Hook Street, Taunton, TA1 1BU",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Taunton"));
            Staff Bateman = new Staff("Jason", "Bateman", "4 Wrens Close, Exeter, EX12 1BT",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Exeter"));



        }

    }
}
