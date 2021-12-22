using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace AvatradeTests.Utils
{
    class Log
    {
        static string pathLogs = "../../../Logs/YahooFinance.log";
        static string pathDirectoryLogs = "../../../Logs";
        static Log()
        {
            if (Directory.Exists(pathDirectoryLogs))
                Directory.CreateDirectory(pathDirectoryLogs);
            if (File.Exists(pathLogs))
                File.Delete(pathLogs);
            Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File(pathLogs, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
        }

        public static void Info(string message)
        {
            Serilog.Log.Information(message);
        }
    }
}
