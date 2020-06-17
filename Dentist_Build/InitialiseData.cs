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
            Practice taunton = new Practice("Taunton");
            Practice bridgwater = new Practice("Bridgwater");
            Practice exeter = new Practice("Exeter");
            CentralisedRecords.InitialiseNewPractice(taunton);
            CentralisedRecords.InitialiseNewPractice(bridgwater);
            CentralisedRecords.InitialiseNewPractice(exeter);




            //Initialise Staff Records
            //
            Staff Sansom = new Staff("Elizabeth", "Sansom", "3 Cyril Street, Taunton, TA2 6HW",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Taunton"));
            Staff Shaun = new Staff("Duncan", "Shaun", "7 Hook Street, Taunton, TA1 1BU",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Taunton"));
            Staff Smith = new Staff("Michael", "Smith", "13 Smithy, Wellington, TA14 3ZY",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Taunton"));


            Staff Bateman = new Staff("Jason", "Bateman", "4 Wrens Close, Exeter, EX12 1BT",
                new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Exeter"));
            Staff Pierce = new Staff("Pierce", "Brosnan", "5 Tank Street, Exeter, EX11, 5TT",
              new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Exeter"));

            Staff Cruise = new Staff("Tom", "Cruise", "15 Alpha Street, Exeter, EX1 2BB",
              new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Exeter"));

            Staff Stone = new Staff("John", "Stone", "The Burke, Bridgwater, TA5, 1AX",
               new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Bridgwater"));
            Staff Sword = new Staff("Chris", "Bent", "12 Burns Road, Bridgwater, TA5 4TY",
              new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Bridgwater"));

            Staff Swift = new Staff("Jay", "Swift", "55 West Street, Bridgwater, TA5 1ZY",
              new DateTime(10 / 04 / 87), 01823333333, Role.Dentist, CentralisedRecords.FindPractice("Bridgwater"));

            //Initialise Patient Records
            Patient Shaunj = new Patient("Jim", "Shaun", "12 Fake Street, Taunton, TA1 1NN", new DateTime(27 / 10 / 1989), 07001001002, taunton, Sansom);

        }

    }
}
