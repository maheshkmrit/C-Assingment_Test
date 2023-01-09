using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MedicalResearch
{
    class PatientRepo
    {
        private ArrayList _listOfPatient = new ArrayList();

        //Add the Disease
        public void AddPatient(Patient pat)
        {
            int rs = _listOfPatient.Add(pat);
            if(rs==null)
            {
                throw new Exception("Patient Not Added");
            }
        }

        public Patient[] GetAllPatient()
        {
            Patient[] patient = new Patient[_listOfPatient.Count];
            for (int i = 0; i < patient.Length; i++)
            {
                if (_listOfPatient[i] is Patient)
                {
                    patient[i] = _listOfPatient[i] as Patient; //to unbox the object into original form
                }

            }
            return patient;
        }
    }
}
