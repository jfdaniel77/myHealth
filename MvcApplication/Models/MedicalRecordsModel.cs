using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class MedicalRecordsModel
    {
        public int Patientid { get; set; }
        public string Problem { get; set; }
        public string Diagnosis { get; set; }
        public string Assessment { get; set; }
    }
}