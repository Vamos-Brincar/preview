//Register
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int id_crianca { get; set; }
        public string nome { get; set; }

        public int idade { get; set; }
        public string passs { get; set; }
    }
}
//Login