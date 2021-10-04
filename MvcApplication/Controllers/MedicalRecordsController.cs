using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class MedicalRecordsController : Controller
    {
        // GET: MedicalRecords
        [Authorize]
        public ActionResult HealthRecords()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        // GET: MedicalRecords/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

        // GET: MedicalRecords/Edit/5
        [Authorize]
        public ActionResult Patients()
        {
            ViewBag.Message = "Search Patients";

            return View();
        }
        [Authorize]
        public ActionResult Vitals()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
