using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch
{
    /// <summary>
    /// Entity Class
    /// </summary>
    enum  cause{ external_factors, internal_disorder };
    class Disease
    {
        
        public string DiseaseName{ get; set; }

        public string DiseaseSeverity { get; set; }




        public string DiseaseCause { get; set; }
        //if (value.Contains("external factors") || value.Contains("ixternal factors"))
        //{
        //    value = value;
        //}

        //string Dbcause;

        //public string DsCause(string cause)
        //{
        //    if(Enum.GetName(cause))
        //    {
        //        Dbcause = Enum.Parse(cause);
        //    }
        //}

    }
}
