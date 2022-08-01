using Microsoft.EntityFrameworkCore;
using PolloRapiApi.Models;

namespace PolloRapiApi.Data
{
    public class PolloRapiContext: DbContext
    {
        public PolloRapiContext(DbContextOptions<PolloRapiContext> options) 
            : base(options) 
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet <Promocion> Promociones { get; set; }
        public DbSet <ProductoPromocion> ProductoPromociones { get; set; }

    }
}
