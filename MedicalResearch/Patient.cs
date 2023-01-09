using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch
{
    class Patient
    {
        Disease PDisease;
        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public void SetDisease (Disease ds)
        {
            PDisease = ds;
        }

        public Disease GetDisease()
        {
            return this.PDisease;
        }


    }
}
