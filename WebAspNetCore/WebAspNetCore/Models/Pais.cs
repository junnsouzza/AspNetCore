using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAspNetCore.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pais(string nome)
        {
            Nome = nome;
        }

        public Pais()
        {
            
        }
    }
}
