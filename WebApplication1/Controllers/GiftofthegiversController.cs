using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GiftofthegiversController : Controller
    {
        // GET: Giftofthegivers
        public ActionResult GiftOfThegivers()
        {

            
            return View();
        }
        
        public ActionResult addHealtCare(string Name,string Description,string Location)
        {
            HealthCare health = new HealthCare();
            health.Name = Name;
            health.Description = Description;
            health.Location = Location;
            List<HealthCare> list = new List<HealthCare>();
            list.Add(health);
            return View(list);
        }
        public ActionResult addMedicene(string medName,string medPetient,string medType,string prescription)
        {
            Medication meds = new Medication();
            meds.MedicationName = medName;
            meds.PatientName = medPetient;
            meds.MedicationType = medType;
            meds.Prescription = prescription;
            meds.UnderTreatment = true;
           List<Medication> list = new List<Medication>();
            list.Add(meds);
            return View(list);
        }
        public ActionResult addVaccine(string vacName, string vacPatient,string vacDescription,string vacType)
        {
            Vaccinations vaccine = new Vaccinations();
            vaccine.VancineName = vacName;
            vaccine.VacineDescription = vacDescription;
            vaccine.PatientName = vacPatient;
            vaccine.VacineType = vacType;
            vaccine.Vaccinated = true;
           List<Vaccinations> list = new List<Vaccinations>();
            list.Add(vaccine);
            return View(list);
        }
    }
}