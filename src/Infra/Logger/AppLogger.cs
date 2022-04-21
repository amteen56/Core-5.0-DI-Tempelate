using Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Logger
{
    public class AppLogger : IAppLogger
    {

        Serilog.Core.Logger logger;
        public AppLogger(Serilog.Core.Logger oLogger)
        {
            logger = oLogger;
        }
        public void LogWarning(string message, params object[] args)
        {
            logger.Warning(message, args);
        }
        public void LogInformation(string message, params object[] args)
        {
            logger.Information(message, args);
            // Log.CloseAndFlush();
        }
        public void LogError(string message, params object[] args)
        {
            logger.Error(message, args);
            //Log.CloseAndFlush();
        }
        public void LogError(Exception ex, string message, params object[] args)
        {
            logger.Error(ex, message, args);
            //Log.CloseAndFlush();
        }
        public void LogError(Exception ex, string message)
        {
            logger.Error(ex, message);
            //Log.CloseAndFlush();
        }
    }
}
