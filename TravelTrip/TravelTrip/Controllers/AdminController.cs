using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
    }
}