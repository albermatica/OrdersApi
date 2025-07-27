using Microsoft.EntityFrameworkCore;
using OrdersApi.Models;

namespace OrdersApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets para tus entidades. EF Core las mapeará a tablas en la DB.
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
