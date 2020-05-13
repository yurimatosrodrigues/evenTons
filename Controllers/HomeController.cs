using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using evenTons.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;

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
            ViewBag.Mensagem = "Mensagem gerada em " + DateTime.Now; 

            return View();
        }

        [HttpGet]
        public IActionResult Calculadora(double? pvDouValor1, double? pvDouValor2) {
            ViewBag.pvDouValor1 = pvDouValor1;
            ViewBag.pvDouValor2 = pvDouValor2;
            return View();
        }       


        [HttpPost]
        public IActionResult Calculadora(IFormCollection form) {
            double douValor1 = double.Parse(form["valor1"]);
            double douValor2 = double.Parse(form["valor2"]);

            double douResultado = douValor1 + douValor2;
            ViewBag.Resultado = "Resultado da soma: " + douResultado;

            return View();
        }


        // Actions usados com a classe produto
        [HttpGet]
        public IActionResult IncluirProduto01() {
            return View();
        }

        [HttpPost]
        public IActionResult IncluirProduto01(Product pvClsProduto) {
            StreamWriter LSw = new StreamWriter("wwwroot/pdf/documento.txt", false, Encoding.UTF8);
            LSw.WriteLine("Código: " + pvClsProduto.Codigo);
            LSw.WriteLine("Descrição: " + pvClsProduto.Descricao);
            LSw.WriteLine("Preço: " + pvClsProduto.Preco);
            LSw.WriteLine("Data de Fabricação: " + pvClsProduto.DataFabricacao);
            LSw.Close();

            //return View();        

            return File("~/pdf/documento.txt", "text/plain");
        }

        public IActionResult ExibirProduto() {
            
            Product clsProduto = new Product()
            {
                Codigo = 25,
                Descricao = "Bike",
                Preco = 500,
                DataFabricacao = Convert.ToDateTime("13/06/1999")
            };

            return View(clsProduto);
        }

    }
}
