using API_Palusa.models;
using Microsoft.EntityFrameworkCore;

namespace API_Palusa.DAO
{
    public class ConnectionContext : DbContext
    {
        public DbSet<estoque> estoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseNpgsql(
         "Server=maglev.proxy.rlwy.net;" +
         "Port=30619;" +
         "Database=railway;" +
         "Username=postgres;" +
         "Password=OIJcvSoOFcekJmSTXRxJjVBzcWfXhcRP;");

    }
}
