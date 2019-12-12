using log4net;
using System;
using System.Reflection;

namespace api__ProS.GestaoServico
{
    public class ProSLogger
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string nomeModuloLog = "ProS.GestaoServico - {0}";

        public void Debug(string modulo, string message)
        {
            LogicalThreadContext.Properties["Modulo"] = string.Format(nomeModuloLog,modulo);

            if (log.IsDebugEnabled)
            {
                log.Debug(message);
            }
        }

        public void Info(string modulo, string message)
        {
            
            string val = string.Format(nomeModuloLog, modulo);

            LogicalThreadContext.Properties["Modulo"] = string.Format(nomeModuloLog, modulo);

            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public void Error(string modulo, string message, Exception ex)
        {
            LogicalThreadContext.Properties["Modulo"] = string.Format(nomeModuloLog, modulo);

            if (log.IsErrorEnabled)
            {
                log.Error(message, ex);
            }
        }
    }
}
