using Microsoft.Extensions.Logging;
using System;

namespace docx_file_content_viewer.Loggers
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private string _filePath;

        public FileLoggerProvider(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(_filePath);
        }

        public void Dispose()
        {
        }
    }
}
