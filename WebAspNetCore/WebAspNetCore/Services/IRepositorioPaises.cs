using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetCore.Models;

namespace WebAspNetCore.Services
{
    public interface IRepositorioPaises
    {
        List<Pais> ObterPaises();
    }
}
