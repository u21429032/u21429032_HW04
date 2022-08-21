using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HealthCare : GiftOfTheGivers
    {
        public string Location { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        HealthCare[] care = new HealthCare[10];
       
       
       

    }
}