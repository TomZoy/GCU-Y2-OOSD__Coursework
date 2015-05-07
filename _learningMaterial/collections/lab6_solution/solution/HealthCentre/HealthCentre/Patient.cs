using System;

namespace HealthCentreSystem
{
    
    public class Patient : IPerson
    {
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
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public Patient(string firstName, string lastName, string id, 
            string dateOfBirthString, string status)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.dateOfBirth = Convert.ToDateTime(dateOfBirthString);
            this.status = status;
        }

        public string GetFullName()
        {
            return String.Format("{1}, {0}", firstName, lastName);
        }

    }
}
