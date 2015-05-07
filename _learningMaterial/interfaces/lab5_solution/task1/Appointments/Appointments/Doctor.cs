using System;

namespace Appointments 
{
    public class Doctor : IPerson
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string speciality;

        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        private int numberOfPaidAppointments;

        public int NumberOfPaidAppointments
        {
            get { return numberOfPaidAppointments; }
        }

        public Doctor(string id, string firstName, string lastName, string speciality)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.speciality = speciality;
            numberOfPaidAppointments = 0;
        }

        public string GetFullName()
        {
            return String.Format("Dr. {0} {1}", firstName, lastName);
        }
    }
}
