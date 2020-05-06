using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using evenTons.Models;
using System.IO;

namespace evenTons.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public FileResult Arquivo(){
            return File("~/pdf/currículo.pdf", "application/pdf");
        }

        public IActionResult Resultado() {
            ViewData["valor1"] = "Primeiro resultado";
            //ViewBag.Mensagem = "Mensagem gerada em " + DateTime.Now; 

            return View();
        }

    }
}
