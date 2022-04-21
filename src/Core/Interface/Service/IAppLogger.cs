using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface.Service
{
    public interface IAppLogger
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
        void LogError(Exception ex, string message, params object[] args);
        void LogError(Exception ex, string message);
    }
}
