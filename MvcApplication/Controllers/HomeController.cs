using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Dashboard()
        {
            if (User.Identity.IsAuthenticated)
            {
                //string email = ((ClaimsIdentity)User.Identity).FindFirst("nickname").Value;
                string email = "mgray@yahoo.com";
                Session["email"] = email;
            }
            else
            {
                Response.Redirect("~/Account/Login");
            }
            return View();
        }
        public ActionResult Appointment()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HealthRecords()
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