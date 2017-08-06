using System;
using NuKeeper.Configuration;

namespace NuKeeper.Logging
{
    public class ConsoleLogger : ILogger
    {
        private readonly LogLevel _logLevel;

        public ConsoleLogger(Settings settings)
        {
            _logLevel = settings.LogLevel;
        }

        public void Error(string message, Exception ex)
        {
            Console.WriteLine($"{message} {ex.GetType().Name} : {ex.Message}");
        }

        public void Info(string message)
        {
            if (_logLevel > LogLevel.Error)
            {
                Console.WriteLine(message);
            }
        }

        public void Verbose(string message)
        {
            if (_logLevel > LogLevel.Info)
            {
                Console.WriteLine(message);
            }
        }
    }
}