using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Code_Challenge_10_Q2.Models;

namespace Code_Challenge_10_Q2.Repository
{
    public interface IRepository
    {
        List<Movie> GetAllMovies();

        Movie GetMovieById(int id);

        void AddMovie(Movie movie);

        void UpdateMovie(Movie movie);

        void DeleteMovie(int id);

        List<Movie> GetMoviesByYear(int year);

        List<Movie> GetMoviesByDirector(string directorName);
    }
}