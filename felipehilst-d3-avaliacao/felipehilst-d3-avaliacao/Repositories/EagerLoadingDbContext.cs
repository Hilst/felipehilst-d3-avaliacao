using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Repositories
{
    public class EagerLoadingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

            var configuration = configBuilder.Build();

            var connectionString = configuration["PostgresConnectionString"];

            optionsBuilder
                .UseNpgsql(connectionString)
                .UseSnakeCaseNamingConvention();
        }

        public DbSet<User>? Users { get; set; }
    }
}
