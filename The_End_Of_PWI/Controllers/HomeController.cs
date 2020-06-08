using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_End_Of_PWI.Models;

namespace The_End_Of_PWI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cookie = new HttpCookie("language");
            cookie.Value = "US";
            Response.Cookies.Add(cookie);
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
            ContactViewModel contact = new ContactViewModel();
            return PartialView("Form", contact);
        }
        public PartialViewResult Home()
        {
            return PartialView("MainPage");
        }
    }
}