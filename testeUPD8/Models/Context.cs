using Microsoft.EntityFrameworkCore;

namespace testeUPD8.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Configura conexão com banco
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost;Database=DATA_UPD;Trusted_Connection=True;");

        }
    }
}
