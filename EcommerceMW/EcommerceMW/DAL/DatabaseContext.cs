using EcommerceMW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMW.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ) : base(options)
        {

        }

        public DbSet<Country>Countries { get; set; }

    }
}
