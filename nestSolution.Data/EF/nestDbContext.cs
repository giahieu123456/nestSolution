using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Data.EF
{
    public class NestDbContext : DbContext
    {
        public NestDbContext(DbContextOptions options): base(options)
        {
        }
    }
}
