using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarStore.WebUI.Models.Identity
{
    public class IdentityContext:IdentityDbContext
    {
        public IdentityContext():base("IdentityDb")
        {

        }

        static IdentityContext()
        {
            Database.SetInitializer<IdentityContext>(new DbInit());
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }


    public class DbInit : DropCreateDatabaseAlways<IdentityContext>
    {
        protected override void Seed(IdentityContext context)
        {
            base.Seed(context);
        }
    }
}