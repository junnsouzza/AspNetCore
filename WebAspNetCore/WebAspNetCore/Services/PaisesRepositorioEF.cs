using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetCore.Data;
using WebAspNetCore.Models;

namespace WebAspNetCore.Services
{
    public class PaisesRepositorioEF : IRepositorioPaises
    {
        public ApplicationDbContext DbContext { get; }

        public PaisesRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Pais> ObterPaises()
        {
            return DbContext.Paises.ToList();
        }
    }
}
