using DAL.Interfaces;
using Dapper;
using LivrosAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class LivroDAL
    {
        private List <Livro> _lstLivro;

        public List<Livro> ListaLivros()
        {
            /*_lstLivro.Add
            (
                new Livro
                {
                    Id = 1,
                    Titulo = "The Phoenix Project: A Novel about IT, DevOps, and Helping Your Business Win",
                    Edicao = 0,
                    EditoraId = 1,
                    ISBN = "",
                    UrlImagem = "",
                    Valor = 100.0
                });*/

            using (var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                return connection.Query<Livro>(
                    "spListaLivros",
                    commandType: System.Data.CommandType.StoredProcedure).ToList(); 
            }

            //return _lstLivro;
        }


        

    }

}

