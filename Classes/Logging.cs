using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{

    internal enum LogSeverity
    {
        Warning = 0,
        Info = 1,
        Error = 2,
        Critical = 3,
    }
    class Logging
    {
        internal static List<Log> Logs = new List<Log>();

        internal static void Log(string Msg, LogSeverity severity, object sender)
        {
            Log log = new Log {
                Context = Msg,
                Severity = severity,
                Origin = sender
            };
            Logs.Add(log);
        }
    }


    internal class Log
    {
        public string Context { get; set; }
        public LogSeverity Severity { get; set; }
        public object Origin { get; set; }
    }
}
