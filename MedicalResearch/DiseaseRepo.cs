using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch
{
    class DiseaseRepo
    {
        
        private ArrayList _listOfDiseases = new ArrayList();

        //Add the Disease
        public void AddDisease(Disease des)
        {
            _listOfDiseases.Add(des);


        }

        //Get All Diseases
        public Disease[] GetAllDisease()
        {
            Disease[] disease = new Disease[_listOfDiseases.Count];
            for (int i = 0; i < disease.Length; i++)
            {
                if(_listOfDiseases[i] is Disease)
                {
                    disease[i] = _listOfDiseases[i] as Disease;//to unbox the object into original form
                }

            }
            return disease;
        }


    }
}
