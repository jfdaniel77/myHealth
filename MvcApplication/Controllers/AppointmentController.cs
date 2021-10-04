using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        public ActionResult Appointment()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}