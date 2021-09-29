using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace thSolution.Repository.Context
{
    public class ThSolutionDbContextFactory : IDesignTimeDbContextFactory<ThSolutionDbContext>
    {
        public ThSolutionDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ThSolutionDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ThSolutionDbContext(optionsBuilder.Options);
        }
    }
}
