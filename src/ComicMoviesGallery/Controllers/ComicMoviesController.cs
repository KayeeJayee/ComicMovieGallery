using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicMoviesGallery.Controllers
{
    public class ComicMoviesController : Controller
    {
        
        public ActionResult Detail()
        {
            ViewBag.MovieTitle = "Amazing Spiderman";
            ViewBag.description = "<p>The amazing spiderman is a 2012 movie.</p>";
            ViewBag.artists = new string[]
            {
                "Actor: KJ Millar",
                "Director: Sharee Lane",
                "Writer: Uzair Ilahi"
            };
            return View();
        }
    }
}