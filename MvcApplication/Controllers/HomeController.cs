﻿using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Medications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Notifications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MyProfile()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}