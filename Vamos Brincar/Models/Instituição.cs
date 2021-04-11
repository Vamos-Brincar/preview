//Register

//Login
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Instituicao
    {
        public int id_inst { get; set; }
        public string nome { get; set; }
        public string pass { get; set; }
    }
}