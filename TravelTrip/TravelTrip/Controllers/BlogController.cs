﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        public ActionResult BlogDetay(int id)
        {
            var blog = c.Blogs.Where(x => x.ID == id).ToList();
            return View(blog);
        }
    }
}