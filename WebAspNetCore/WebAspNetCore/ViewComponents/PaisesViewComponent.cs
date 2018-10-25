using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetCore.Services;

namespace WebAspNetCore.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public IRepositorioPaises Rep { get; }

        public PaisesViewComponent(IRepositorioPaises rep)
        {
            Rep = rep;
        }
        
        public IViewComponentResult Invoke()
        {
            var paises = Rep.ObterPaises();
            return View(paises);    
        }
    }
}
