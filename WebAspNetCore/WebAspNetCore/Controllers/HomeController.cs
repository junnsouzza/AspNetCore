using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAspNetCore.Models;
using WebAspNetCore.Services;

namespace WebAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IRepositorioPaises Repositorio { get; }

        public HomeController(IRepositorioPaises repositorio)
        {
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            var paises = Repositorio.ObterPaises();
            return View(paises);
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
}
