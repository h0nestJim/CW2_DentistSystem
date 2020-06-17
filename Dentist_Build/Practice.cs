using System;
using System.Collections.Generic;

namespace Dentist_Build
{
    public class Practice
    {

        public string location;
        public List<Staff> ActivePracticeStaff = new List<Staff>();

        private List<Appointment> patientAppointments = new List<Appointment>();

        public Practice(string Location)
        {
            this.location = Location;
        }

        public Practice GetData()
        {
            return this;
        }

        public void SubmitAppointment(Appointment appointment)
        {
            patientAppointments.Add(appointment);
        }



    }
}
