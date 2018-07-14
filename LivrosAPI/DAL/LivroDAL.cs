using DAL.Interfaces;
using Dapper;
using LivrosAPI.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class LivroDAL: ILivroDAL
    {
        public List<Livro> ListaLivros()
        {
            using (var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                return connection.Query<Livro>(
                    "spListaLivros",
                    commandType: System.Data.CommandType.StoredProcedure).ToList(); ;
            }
        }

    }
}
