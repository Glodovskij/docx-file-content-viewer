using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace docx_file_content_viewer.Loggers
{
    public class FileLogger : ILogger
    {
        private string _filepath;
        private static object _lock = new object();

        public FileLogger(string path)
        {
            _filepath = path ?? throw new ArgumentNullException(nameof(path));
        }

        public IDisposable BeginScope<TState>(TState state) => default;

        public bool IsEnabled(LogLevel logLevel)
        {
            // By default this logger will be available any time.
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock(_lock)
                {
                    File.AppendAllText(_filepath, formatter(state, exception) + Environment.NewLine);
                }
            }
        }
    }
}
