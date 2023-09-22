using AmericanSportApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AmericanSportApp.Data
{
    public class DbContext1 : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext1(DbContextOptions<DbContext1> options)
         : base(options)
        {
        }

        public DbSet<People> Person { get; set; }
    }
}
