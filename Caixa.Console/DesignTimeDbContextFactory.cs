using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Data.Context;

namespace Caixa.Console
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppSqliteContext>
    {
        public AppSqliteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppSqliteContext>();
            string dbPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Caixa.UI", "JambooCaixa.db");
            // Add services to the container.
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new AppSqliteContext(optionsBuilder.Options);
        }
    }
}
