using LivrosAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    interface ILivroBLL
    {
        List<Livro> ListaLivros();
    }
}
