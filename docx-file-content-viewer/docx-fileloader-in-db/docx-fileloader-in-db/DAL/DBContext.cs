using Microsoft.EntityFrameworkCore;

namespace docx_fileloader_in_db.DAL
{
    class DBContext : DbContext
    {
        public DBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-E3KKR8J\SQLEXPRESS;Database=DOCX;Trusted_Connection=True;");
            }
        }

        public DbSet<File> Files { get; set; }
    }
}
