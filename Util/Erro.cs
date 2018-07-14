using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Util
{
    public static class Erro
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Log(this Exception err)
        {
            Logger.Error(err);
        }
    }
}