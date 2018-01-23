using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActivitySignUp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Acme Widget Company employee activity squad has random fun events throughout the year. They have asked Technical Solutions to develop a simple Activity Sign Up web application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information";

            return View();
        }
    }
}