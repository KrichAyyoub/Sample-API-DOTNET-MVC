using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testdotnetcore.Models;

namespace testdotnetcore.Controllers
{
    public class MoviesController : Controller
    {
        // to GET a random Movie
        public ActionResult Random()
        {
            Movie movie = new Movie { Name = "The Weding Ringer" };
            return View(movie);
        }
        // Just testing for edit view
        public ActionResult editId(int id)
        {
            return Content("id : :" +id);
        }
        // Custom route
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }


    }
}
