using LivrosAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    interface ILivroDAL
    {
        List<Livro> ListaLivros();
    }
}
