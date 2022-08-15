using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        BlogYorum by = new BlogYorum();
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            return View(by);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
    }
}