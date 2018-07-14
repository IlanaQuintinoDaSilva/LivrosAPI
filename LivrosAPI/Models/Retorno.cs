using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrosAPI.Models
{
    public class Retorno
    {
        public Retorno()
        {
            Success = false;
            Description = "";
            Data = null;
            ErrorCode = 0;
        }

        public object Data { get; set; }

        public bool Success { get; set; }

        public string Description { get; set; }

        public int ErrorCode { get; set; }
    }
}