using API_Palusa.models;
using Microsoft.EntityFrameworkCore;

namespace API_Palusa.DAO
{
    public class ConnectionContext : DbContext
    {
        public DbSet<estoque> estoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseNpgsql(
         "Server=accusingly-energetic-basset.data-1.use1.tembo.io;" +
         "Port=5432;" +
         "Database=postgres;" +
         "Username=postgres;" +
         "Password=CXHwUKcvWhv05oIe;");

    }
}
