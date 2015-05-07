using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appointments
{
    public class Doctor : IPerson
    {
        protected string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        protected string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        protected string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected string speciality;

        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }


        public Doctor(string id, string firstName, string lastName, string speciality)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.speciality = speciality;
        }

        public virtual string GetFullName()
        {
            return String.Format("Dr. {0} {1}", firstName, lastName);
        }
    }
}
