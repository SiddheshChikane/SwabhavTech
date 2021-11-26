using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSln.Common_Module;
namespace DIPSln.Low_Level_Module
{
    class DBLogger:ILogger
    {
        public string Log()
        {
            string message = "Logging to DB";
            return message;
        }
    }
}
