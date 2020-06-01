using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The_End_Of_PWI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult About()
        {
            ViewBag.Message = "Your application description page.";

            return PartialView("About");
        }

        public PartialViewResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView("Contact");
        }
        public PartialViewResult Form()
        {
            return PartialView("Form");
        }
    }
}