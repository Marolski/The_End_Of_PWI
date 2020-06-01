using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace The_End_Of_PWI.Database
{
    public class ContactInitializer : DropCreateDatabaseIfModelChanges<ContactContext>
    {
        protected override void Seed(ContactContext context)
        {
            base.Seed(context);
        }
    }
}