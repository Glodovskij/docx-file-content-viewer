using docx_file_content_viewer.Domain.Repositories;
using docx_file_content_viewer.Domain.Services;
using docx_file_content_viewer.Infrastructure.Repositories.EF;
using docx_file_content_viewer.Infrastructure.Repositories.Repositories;
using docx_file_content_viewer.Infrastructure.Services.Docx;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace docx_file_content_viewer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            string connectionString = Configuration.GetConnectionString("ApplicationConnection");

            services.AddDbContext<DocxDbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<IDocxFileRepository, DocxFileRepository>();

            services.AddTransient<IDocxFileService, DocxFileService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
