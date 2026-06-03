using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Code_Challenge_10_Q2.Models;

namespace Code_Challenge_10_Q2.Repository
{
    public class MovieRepository : IRepository
    {
        MoviesContext db = new MoviesContext();

        public List<Movie> GetAllMovies()
        {
            return db.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return db.Movies.Find(id);
        }

        public void AddMovie(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            Movie m = db.Movies.Find(movie.Mid);

            if (m != null)
            {
                m.MovieName = movie.MovieName;
                m.DirectorName = movie.DirectorName;
                m.DateOfRelease = movie.DateOfRelease;

                db.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            Movie m = db.Movies.Find(id);

            if (m != null)
            {
                db.Movies.Remove(m);
                db.SaveChanges();
            }
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            return db.Movies
                     .Where(x => x.DateOfRelease.Year == year)
                     .ToList();
        }

        public List<Movie> GetMoviesByDirector(string directorName)
        {
            return db.Movies
                     .Where(x => x.DirectorName == directorName)
                     .ToList();
        }
    }
}