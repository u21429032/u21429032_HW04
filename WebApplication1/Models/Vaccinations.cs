using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
   public class Vaccinations: GiftOfTheGivers
    {
        public string VancineName { get; set; } 
        public string VacineDescription { get; set; }
        public string VacineType { get; set; }
        public string PatientName { get; set; }
        Vaccinations[] Vacci;
        public override void vacination()
        {
            Vaccinations[] vacines;
        }
    }
}