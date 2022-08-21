using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public abstract class GiftOfTheGivers
    {
        public string SDG = "Good Health and well-being";
        public bool Vaccinated { get; set; }
        public bool UnderTreatment { get; set; }
       
        public virtual void Medicine()
        {
           
        }
        public virtual void vacination()
        {
           
        }

    }
}