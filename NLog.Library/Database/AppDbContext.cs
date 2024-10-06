using Microsoft.EntityFrameworkCore;
using NLog.Library.Models;

namespace NLog.Library.Database
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CYBER;Initial Catalog=NLogDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Log> Logs { get; set; }

    }
}
