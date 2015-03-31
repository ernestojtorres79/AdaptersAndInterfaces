using AdaptorsInterfaces.Adapters.Adapters;
using AdaptorsInterfaces.Adapters.Interfaces;
using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdaptorsInterfaces.Controllers
{
    public class HomeController : Controller
    {
        IMovieAdapter _adapter;
        IReviewAdaptor _reviewAdaptor;
        public HomeController()
        {
            _adapter = new MovieAdapter();
            _reviewAdaptor = new ReviewAdaptor();
        }
        public HomeController(IMovieAdapter adapter, IReviewAdaptor reviewAdaptor)
        {
            _adapter = adapter;
            _reviewAdaptor = reviewAdaptor;
        }
        public ActionResult Index()
        {
            List<Movie> model = _adapter.GetAllMovies();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(Movie newMovie)
        {
            _adapter.AddMovie(newMovie);

            return RedirectToAction("Index");
        }

        public ActionResult DetailsMovie(int id)
        {
            Movie model = _adapter.DetailMovie(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult DetailsMovie(Review review)
        {
            _reviewAdaptor.AddReview(review);
            return RedirectToAction("DetailsMovie/"+ review.MovieId);
        }
        public ActionResult EditMovie(int id)
        {
            Movie model = _adapter.DetailMovie(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie movie)
        {
            Movie model = _adapter.EditMovie(movie);
            return RedirectToAction("DetailsMovie/" + model.MovieId);
        }

        public ActionResult DelMovie(int id)
        {
            _adapter.DeleteMovie(id);
            return RedirectToAction("Index");
        }
        
    }
}