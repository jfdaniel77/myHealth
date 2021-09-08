﻿using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;

namespace MvcApplication.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            HttpContext.GetOwinContext().Authentication.Challenge(new AuthenticationProperties
                {
                    RedirectUri = returnUrl ?? Url.Action("Dashboard", "Home")
                },
                "Auth0");
            return new HttpUnauthorizedResult();
        }

        [Authorize]
        public void Logout()
        {
            HttpContext.Session.RemoveAll();
            
            HttpContext.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            HttpContext.GetOwinContext().Authentication.SignOut("Auth0");
        }

        [Authorize]
        public ActionResult Tokens()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;

            ViewBag.AccessToken = claimsIdentity?.FindFirst(c => c.Type == "access_token")?.Value;
            ViewBag.IdToken = claimsIdentity?.FindFirst(c => c.Type == "id_token")?.Value;
            ViewBag.Email = claimsIdentity?.FindFirst(c => c.Type == "email")?.Value;
            return View();
        }

        [Authorize]
        public ActionResult Claims()
        {
            return View();
        }
    }
}