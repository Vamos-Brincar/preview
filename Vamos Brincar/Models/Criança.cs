//Register
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Crianca
    {
        public int id_crianca { get; set; }
        public string nome { get; set; }

        public int idade { get; set; }
        public string pass { get; set; }
    }
}
//Login