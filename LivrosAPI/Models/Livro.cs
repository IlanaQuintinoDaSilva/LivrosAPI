using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrosAPI.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string NomeEditora { get; set; }
        public double Valor { get; set; }
        public string UrlImagem { get; set; }
    }
}