using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace WebApplication1
{
    public class SchoolContext:DbContext
    {
        IConfiguration appConfig;

        public SchoolContext(IConfiguration config)
        {
            appConfig = config;
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(appConfig.GetConnectionString("SchoolDBLocalConnection"));
        }
    }
}
