using Serilog;
using Serilog.Core;
using System;

namespace StrategyPattern
{
    class Log : ILog
    {
        private Logger logger;

        public Log()
        {
            logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logfile.log")
                .CreateLogger();

        }

        public void Debug(string text)
        {
            logger.Debug(text);
        }

        public void Error(string text)
        {
            logger.Error(text);
        }
    }
}
