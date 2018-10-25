using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetCore.Models;

namespace WebAspNetCore.Services
{
    public class PaisesRepositorioMemoria: IRepositorioPaises
    {
        public List<Pais>ObterPaises()
        {
            List<Pais> Paises = new List<Pais>()
            {
                new Pais("Chile"),
                new Pais("Brasil"),
                new Pais("Colombia")
            };
            return Paises;
        }
    }
}
