using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}