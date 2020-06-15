using System;
using System.Collections.Generic;

namespace Dentist_Build
{
    public class Practice
    {
        public string location;
        private List<Staff> ActivePracticeStaff = new List<Staff>();


        public Practice(string Location)
        {
            this.location = Location;
        }

        public Practice GetData()
        {
            return this;
        }

    }
}
