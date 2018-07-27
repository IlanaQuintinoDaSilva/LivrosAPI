using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrosAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Edicao { get; set; }
        public int EditoraId { get; set; }
        public string ISBN { get; set; }
        public string UrlImagem { get; set; }
        public double Valor { get; set; }
        //public DateTime DtPublicacao { get; set; }

    }
}