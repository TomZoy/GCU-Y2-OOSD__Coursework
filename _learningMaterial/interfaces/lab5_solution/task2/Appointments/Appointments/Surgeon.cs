using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appointments
{
    public class Surgeon : Doctor
    {
        private string hospital;

        public string Hospital
        {
            get { return hospital; }
            set { hospital = value; }
        }

        public Surgeon(string id, string firstName, string lastName, string speciality, string hospital) :
            base(id, firstName, lastName, speciality)
        {
            this.hospital = hospital;
        }

        public DateTime NextAvailableAppointment()
        {
            return DateTime.Now.AddDays(7);
        }

        public override string GetFullName()
        {
            return String.Format("Mr. {0} {1}", firstName, lastName);
        }
    }
}
