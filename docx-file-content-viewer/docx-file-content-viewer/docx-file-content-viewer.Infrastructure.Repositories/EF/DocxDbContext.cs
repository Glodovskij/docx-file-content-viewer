using docx_file_content_viewer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace docx_file_content_viewer.Infrastructure.Repositories.EF
{
    public class DocxDbContext : DbContext
    {
        public DocxDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DocxFile> DocxFiles {get; set;}
    }
}
