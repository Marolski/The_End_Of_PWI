using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.Web.Mvc.CompareAttribute;

namespace The_End_Of_PWI.Models
{
    public class ContactViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is require")]
        [RegularExpression("^(?=.{5,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username can be from 5 to 15 characters and exclude special symbols")]
        public string Name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is require")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone Number is require")]
        public string Telephone { get; set; }

    }
}