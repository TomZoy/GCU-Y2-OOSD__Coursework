// uncomment one of these #define statements only to select List or Dictionary version
// this selects one or other section of code to be included when the class is compiled
#define List
//#define Dictionary

using System;
using System.Collections.Generic;

namespace HealthCentreSystem
{
    public class HealthCentre
    {
        private string centreName;

        public string CentreName
        {
            get { return centreName; }
            set { centreName = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

#if List
        private List<Patient> patients;


        public HealthCentre(string centreName, string address)
        {
            this.centreName = centreName;
            this.address = address;
            patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public Patient GetPatientByID(string ID)
        {
            // use lambda expression as delegate
            return patients.Find(item => item.ID == ID);

            // use anonymous delegate 
            //return patients.Find(delegate(Patient patient)
            //    {
            //        if (patient.ID == ID)
            //            return true;
            //        else
            //            return false;
            //    }
            //);

            // use explicitly defined Predicate (need this method to return a delegate so that it can take an additional parameter)
            //return patients.Find(HasID(ID));
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }

        // explicitly defined Predicate (only needed when using explicitly in GetPatientByID)
        private Predicate<Patient> HasID(string ID)
        {
            return delegate(Patient patient)
            {
                if (patient.ID == ID)
                    return true;
                else
                    return false;
            };
        }
#endif

#if Dictionary
        private Dictionary<string,Patient> patients;


        public HealthCentre(string centreName, string address)
        {
            this.centreName = centreName;
            this.address = address;
            patients = new Dictionary<string, Patient>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient.ID,patient);
        }

        public Patient GetPatientByID(string ID)
        {
            //if (patients.ContainsKey(ID))
            //    return patients[ID];
            //else
            //    return null;

            Patient value;
            patients.TryGetValue(ID, out value);
            return value;
        }

        public ICollection<Patient> GetPatients()
        {
            return patients.Values;
        }
#endif
    }
}
