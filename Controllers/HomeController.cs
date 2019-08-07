using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthCareProject.Models;

namespace HealthCareProject.Controllers
{

    public class HomeController : Controller
    {
        //   PatientInformationForm PatientInformationFormObject = new PatientInformationForm();

        PatientInformationForm PatientInformationObject = new PatientInformationForm("Alpa", "Desai", "64", "120", "WomensVitamins", "NoMajorFamilyHistoryIssue", "NoAllergies", "EyeGlasses", "UptoDateImmunizations", "NormalBloodTest", "2115");

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PatientDatabase()
        {
            PatientInformationObject.CreatePatientDatabase();
            return View(PatientInformationObject);
        }

 
        public IActionResult RecommendAnInsurancePlan()
        {
            PatientInformationObject.CreatePatientDatabase();
            return View(PatientInformationObject);
        }

        public IActionResult RecommendPrimaryCarePhysician()
        {
            PatientInformationObject.CreatePatientDatabase();
            return View(PatientInformationObject);
        }

        public IActionResult RecommendSpecialists()
        {
            PatientInformationObject.CreatePatientDatabase();
            return View(PatientInformationObject);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
