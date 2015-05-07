using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appointments
{
    class GeneralPractitioner : Doctor
    {
        private string practice;

        public string Practice
        {
            get { return practice; }
            set { practice = value; }
        }

        public GeneralPractitioner(string id, string firstName, string lastName, string speciality, string practice) :
            base(id, firstName, lastName, speciality)
        {
            this.practice = practice;
        }

        public DateTime NextAvailableHomeVisit()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
