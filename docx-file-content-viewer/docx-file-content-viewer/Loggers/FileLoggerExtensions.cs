using Microsoft.Extensions.Logging;

namespace docx_file_content_viewer.Loggers
{
    public static class FileLoggerExtensions
    {
        public static ILoggingBuilder AddFile(this ILoggingBuilder loggingBuilder, string filePath)
        {
            loggingBuilder.AddProvider(new FileLoggerProvider(filePath));
            return loggingBuilder;
        }
    }
}
