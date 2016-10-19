using ComicMoviesGallery.Data;
using ComicMoviesGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicMoviesGallery.Controllers
{
    public class ComicMoviesController : Controller
    {
        private ComicMovieRepository _comicMovieRepository = null;

        public ComicMoviesController()
        {
            _comicMovieRepository = new ComicMovieRepository();
        }

        public ActionResult Index()
        {
            var comicMovies = _comicMovieRepository.GetComicMovies();

            return View(comicMovies);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicMovie = _comicMovieRepository.GetComicMovie((int)id);

            return View(comicMovie);
        }
    }
}