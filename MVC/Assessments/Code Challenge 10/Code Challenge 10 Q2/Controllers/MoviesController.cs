using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Challenge_10_Q2.Models;
using Code_Challenge_10_Q2.Repository;

namespace Code_Challenge_10_Q2.Controllers
{
    public class MoviesController : Controller
    {
        IRepository repo = new MovieRepository();
        public ActionResult Index()
        {
            return View(repo.GetAllMovies());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                repo.AddMovie(movie);
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            Movie movie = repo.GetMovieById(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repo.UpdateMovie(movie);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Movie movie = repo.GetMovieById(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
            repo.DeleteMovie(movie.Mid);
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByYear(int year)
        {
            List<Movie> movies = repo.GetMoviesByYear(year);
            return View(movies);
        }

        public ActionResult MoviesByDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByDirector(string directorName)
        {
            List<Movie> movies = repo.GetMoviesByDirector(directorName);
            return View(movies);
        }
    }
}