using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nestSolution.Data.EF
{
    public class nestDbContextFactory : IDesignTimeDbContextFactory<NestDbContext>
    {
        public NestDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connerctionString = configuration.GetConnectionString("nestSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<NestDbContext>();
            optionsBuilder.UseSqlServer(connerctionString);

            return new NestDbContext(optionsBuilder.Options);
        }
    }
}
