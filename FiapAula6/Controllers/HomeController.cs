using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiapAula6.Models;

namespace FiapAula6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var receita = new List<Receita>();
            for (int i = 0; i < 20; i++)
            {
                receita.Add(new Receita() { Nome = $"Receita {i + 1}", Imagem = $"/images/receita{i + 1}.jpg", });
            }
            return View(receita);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Receita
    {
        public string Nome { get; internal set; }
        public string Imagem { get; internal set; }
    }
}
