using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class Users
    {
        public List<Registration> Registrations { get; set; }
        public Registration AddItem { get; set; }
        public string CurrentFirstName { get; set; }


        public void UsersAdd()
        {

            Registrations = new List<Registration>
            {
            new Registration{ID = AddItem.ID, FirstName = AddItem.FirstName, LastName = AddItem.LastName, EmailAddress = AddItem.EmailAddress,
            Password = AddItem.Password, PhoneNumber = AddItem.PhoneNumber
            }
            };

            CurrentFirstName = Registrations.Last().FirstName;

        }

    }
}
