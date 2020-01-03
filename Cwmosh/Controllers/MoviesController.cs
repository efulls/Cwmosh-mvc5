using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cwmosh.Models;
using Cwmosh.ViewModel;

namespace Cwmosh.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Froozzeen!!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer One" },
                new Customer {Name = "Customer Two" }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}