using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class jogo_guardado
    {
        public int id_jogo_guard { get; set; }
        public int id_crianca { get; set; }
        public int id_jogo { get; set; }
        public int pontos { get; set; }
    }
}