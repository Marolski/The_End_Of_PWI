using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_End_Of_PWI.Database;
using The_End_Of_PWI.Models;

namespace The_End_Of_PWI.Controllers
{
    public class RegisterController: HomeController
    {
        private readonly ContactContext dbContext = new ContactContext();
        [HttpPost]
        public void Register(ContactViewModel contact)
        {
            ContactModel ctModel = new ContactModel();
            ctModel.Telephone = contact.Telephone;
            ctModel.Name = contact.Name;
            ctModel.Email = contact.Email;
            dbContext.ContactDb.Add(ctModel);
            dbContext.SaveChanges();
            ViewBag.Info = "Dane zapisane!!";
        }

    }
}