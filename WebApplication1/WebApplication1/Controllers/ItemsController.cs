using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {
        private Users db = new Users();

        //// GET: Items
        //public ActionResult Index()
        //{
        //    return View(db.Items.ToList());
        //}


        public async Task<ActionResult> Index(string searchString)
        {
            var item = from i in db.Items
                         select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                item = item.Where(s => s.Name.Contains(searchString));
            }

            return View(await item.ToListAsync());
        }

    }
}
