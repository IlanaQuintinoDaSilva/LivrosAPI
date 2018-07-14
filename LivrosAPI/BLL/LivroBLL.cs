using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using LivrosAPI.Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class LivroBLL: ILivroBLL
    {
        private readonly ILivroDAL _livroDAL = new LivroDAL();

        List<Livro> ILivroBLL.ListaLivros()
        {
            return _livroDAL.ListaLivros();
        }
    }
}
