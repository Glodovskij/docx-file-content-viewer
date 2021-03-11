using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using docx_file_content_viewer.Loggers;
using Microsoft.Extensions.Logging;

namespace docx_file_content_viewer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddFile("logs.txt");
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
