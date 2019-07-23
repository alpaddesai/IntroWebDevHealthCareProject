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
        PatientInformationForm PatientInformationFormObject = new PatientInformationForm();
  
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PatientInformationForm()
        {
            PatientInformationFormObject.CreatePatientDatabase();
            return View(PatientInformationFormObject);
        }

 
        public IActionResult RecommendAnInsurancePlan()
        {
            PatientInformationFormObject.CreatePatientDatabase();
            return View(PatientInformationFormObject);
        }

        public IActionResult RecommendPrimaryCarePhysician()
        {
            PatientInformationFormObject.CreatePatientDatabase();
            return View(PatientInformationFormObject);
        }

        public IActionResult RecommendSpecialists()
        {
            PatientInformationFormObject.CreatePatientDatabase();
            return View(PatientInformationFormObject);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
