using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Medication: GiftOfTheGivers
    {
        public string MedicationName { get; set; }
        public string MedicationType { get; set; }
        public string Prescription { get; set; }
        public string PatientName { get; set; }
       
        public override void Medicine()
        {
            Medication[] meds;
        }
    }
}