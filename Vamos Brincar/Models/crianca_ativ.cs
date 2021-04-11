using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class crianca_ativ
    {
        public int id_crianca_ativ { get; set; }
        public int id_crianca { get; set; }
        public int id_atividade { get; set; }
    }
}