using System.Web.Mvc;
using System.Security.Claims;
namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Dashboard()
        {
            if (User.Identity.IsAuthenticated)
            {
                string email = ((ClaimsIdentity)User.Identity).FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").Value;
               // string email = "thouston@hotmail.com";
                Session["email"] = email;
            }
            // else
            // {
            //     Response.Redirect("~/Account/Login");
            // }
            return View();
        }
        

        
        public ActionResult Medications()
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