using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class RegistrationController : Controller
    {


        Users users = new Users();

        //public Registration newUser = new Registration();
        //public List<Registration> Test { get; set; }

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Registration newUser)
        {

            if (ModelState.IsValid)
            {
                users.AddItem = newUser;
                users.UsersAdd();
                return View("Summary");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Summary()
        {
            ViewBag.NewUserFirstName = users.CurrentFirstName;
            return View();
        }
    }
}