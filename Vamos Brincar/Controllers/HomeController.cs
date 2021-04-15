using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class VamosBrincarController : Controller
    {        private readonly ILogger<VamosBrincarController> _logger;

        public VamosBrincarController(ILogger<VamosBrincarController> logger)
        {
            _logger = logger;
        }

        public IActionResult VamosBrincar()
        {
            return View();
        }
         public IActionResult Patrocinadores()
        {
            return View();
        }
        public IActionResult Jogos()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
          public IActionResult About()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Crianca()
        {
            return View();
        }
        public IActionResult Instituicao()
        {
            return View();
        }
          public IActionResult Index_Crianca()
        {
            return View();
        }
           public IActionResult Avaliar()
        {
            return View();
        }
    


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
