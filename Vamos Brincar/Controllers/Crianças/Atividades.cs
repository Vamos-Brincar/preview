//Um Get que sirva para digitalizar os dados das atividades nas crianças

//Um Post para que as crianças avaliem as atividades
 
using Microsoft.AspNetCore.Mvc;
  
namespace MvcMovie  
{  
    public class atividadeController : Controller  
    {  
       public string GetAllAtividade()
        {
            return "All atividade";
        }

        public string GetAtividade(int id_atividade)
        {
            return $"atividade with id={id_atividade}";
        }
       
    }  
}



