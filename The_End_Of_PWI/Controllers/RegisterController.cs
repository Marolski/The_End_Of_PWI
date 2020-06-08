using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
            var res1 = "";
            var res2 = "";
            ViewBag.Info = false;
            try
            {
                if (model.Email==null || model.Name==null || model.Telephone==null)
                {
                    if (Request.Cookies["language"].Value == "US")
                    {
                        res2 = App_LocalResources._Layout_cshtml.value;
                    }
                    else res2 = App_LocalResources._Layout_cshtml.valuePL;
                    return Json("<div>"+res2+"</div>");
                }
                dbContext.ContactDb.Add(model);
                dbContext.SaveChanges();
                ViewBag.Info = true;
                if (Request.Cookies["language"].Value == "US")
                {
                    res1 = App_LocalResources._Layout_cshtml.communicat;
                }
                else res1 = App_LocalResources._Layout_cshtml.communicatPL;

            }
            catch (Exception)
            {

                throw new Exception();
            }
            return Json("<div>"+res1+"</div>");
        }
        public void Language()
        {
            if (Request.Cookies["language"].Value == "US")
            {
                Response.Cookies["language"].Value = "PL";
            }
            else Response.Cookies["language"].Value = "US";
        }

    }
}