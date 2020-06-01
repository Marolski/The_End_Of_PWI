using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace The_End_Of_PWI.Database
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("UserContext")
        {
        }
        public DbSet<Models.ContactModel> ContactDb { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}