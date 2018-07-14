using BLL;
using Util;
using BLL.Interfaces;
using LivrosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LivrosAPI.Controllers
{
    [RoutePrefix("api/livros")]
    public class LivroController: ApiController
    {
        private readonly ILivroBLL _livroBLL = new LivroBLL();
        private Retorno _resultado = new Retorno();

        [HttpGet, Route("ListaLivros")]
        public Retorno ListaLivros()
        {
            try
            {
                _resultado.Data = _livroBLL.ListaLivros();
                _resultado.Description = "Lista Livros";
                _resultado.Success = true;
            }
            catch(Exception erro)
            {
                _resultado.Success = false;
                _resultado.Description = "Erro inesperado";
                _resultado.Data = null;
                erro.Log();
            }
            return _resultado;
        }



    }
}