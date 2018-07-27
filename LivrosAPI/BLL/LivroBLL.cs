using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using LivrosAPI.Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class LivroBLL
    {
        private LivroDAL _livroDAL = new LivroDAL();

        public List<Livro> ListaLivros()
        {
            return _livroDAL.ListaLivros();
        }
    }
}
