using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Test
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=DESKTOP-QF3QLUU;Database=Test2DB;Trusted_Connection=True;Encrypt=False", b => b.MigrationsAssembly("WebApplication1"))
                .EnableSensitiveDataLogging();
        }
    }
}
