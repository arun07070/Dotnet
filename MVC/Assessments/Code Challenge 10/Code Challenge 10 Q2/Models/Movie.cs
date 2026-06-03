using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Code_Challenge_10_Q2.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public DateTime DateOfRelease { get; set; }
    }
}