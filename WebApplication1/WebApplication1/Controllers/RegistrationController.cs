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


        private readonly Users _context = new Users();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Registration newUser)
        {

            if (ModelState.IsValid)
            {
                _context.Registrations.Add(newUser);
                return RedirectToAction("Summary");
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Summary()
        {
            int lastID = _context.Registrations.Count();
            var userFirstName = _context.Registrations
                .Where(n => n.ID == lastID).First().FirstName.ToString();
            var model = new Registration
            {
                FirstName = userFirstName
            };

            return View(model);
        }
    }
}