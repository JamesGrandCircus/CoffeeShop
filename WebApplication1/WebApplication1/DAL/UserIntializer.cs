using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class UserIntializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Users>
    {
        protected override void Seed(Users context)
        {
            var users = new List<Registration>
            {
            new Registration{FirstName = "Bilbo", LastName = "Bagins", EmailAddress = "B_Bagins@gmail.com",
            Password = "Ring888", PhoneNumber = "555-555-5555"
            }
            };

            users.ForEach(u => context.Registrations.Add(u));

            context.SaveChanges();
        }
    }

}