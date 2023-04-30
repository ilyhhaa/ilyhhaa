using Data.ForEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EFDBContext:DbContext
    {
        public DbSet<Brewery> Brewery { get; set; } 

        public DbSet<Beer> Beer { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base (options)
        {
            
        }



    }


    public class EFDBContextF : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            string connectionstring = @"Data Source = (localdb)\MSSQLLocalDB";
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer(connectionstring , ob=> ob.MigrationsAssembly("Data"));

            return new EFDBContext(optionsBuilder.Options);
        }
        
    }
}
