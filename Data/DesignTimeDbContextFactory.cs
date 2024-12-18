using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MvcMovie.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MvcMovieContext>
    {
        public MvcMovieContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MvcMovieContext>();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("MvcMovieContext"));

            return new MvcMovieContext(optionsBuilder.Options);
        }
    }
}
