using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public static class BaseDAL
    {
        public static readonly string ConnectionStringSqlServer =
            ConfigurationManager.ConnectionStrings["ConnectionSqlServer"].ConnectionString;
    }
}
