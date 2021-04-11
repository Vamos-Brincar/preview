//Save
using System;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie
{
    public class sugestao
    {
        public int id_sug { get;set;}
        public int id_crianca { get;set;}
        public int id_inst { get;set;}
        public string sug { get;set;}

    }
    

}