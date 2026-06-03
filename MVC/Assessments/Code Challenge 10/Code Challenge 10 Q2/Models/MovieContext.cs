using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Code_Challenge_10_Q2.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("MoviesDB")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}