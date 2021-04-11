//Read

//Save

//Update

//Delete

using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Atividade
    {
        public int id_atividade { get; set; }
        public string nome { get; set; }
         [DataType(DataType.Date)]
        public DateTime data_at { get; set; }
        public string descricao { get; set; }
        public string avaliacao { get; set; }
        
         
    }
}