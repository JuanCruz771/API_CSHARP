using API_Palusa.models;
using Microsoft.EntityFrameworkCore;

namespace API_Palusa.DAO
{
    public class ConnectionContext : DbContext
    {
        public DbSet<estoque> estoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
            var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            var dbData = Environment.GetEnvironmentVariable("DB_DATA");
            var dbUser = Environment.GetEnvironmentVariable("DB_USER");

            var connectionString = $"Server={dbServer};Port={dbPort};Database={dbData};Username={dbUser};Password={dbPassword};";

            optionsBuilder.UseNpgsql(connectionString);
        }
    } // <- FALTAVA ESSA CHAVE!
}
