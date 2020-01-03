    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cwmosh.Models;

namespace Cwmosh.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Froozzeen!!" };
            // return View(movie);
            //return Content("Hello World...!!");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name"});
        }
    }
}