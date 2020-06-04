using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using The_End_Of_PWI.Database;
using The_End_Of_PWI.Models;

namespace The_End_Of_PWI.Controllers
{
    public class RegisterController: HomeController
    {
        private readonly ContactContext dbContext = new ContactContext();
        [HttpPost]
        public JsonResult Register(ContactModel model)
        {
            ViewBag.Info = false;
            try
            {
                dbContext.ContactDb.Add(model);
                dbContext.SaveChanges();
                ViewBag.Info = true;

            }
            catch (Exception e)
            {

                throw new Exception(" Ups, wystąpił błąd. Dane kontakowe nie zostały zapisane.");
            }
            return Json("<div>Wkrótce się odezwę!!</div>");
        }

    }
}