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
        public DbSet<PolloRapiApi.Models.Enumerado>? Enumerado { get; set; }

        public DbSet<EnumeradoJerarquia> EnumeradoJerarquias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }


        #region Required

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.Entity<Enumerado>()
            //    .HasOne(d => d.Padre)
            //  .WithMany(p => p.Hijo)
            //.OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Enumerado>().
                HasMany(p => p.Ancestros)
                .WithOne(d => d.Descendiente)
               .HasForeignKey(d => d.DescendienteId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Enumerado>().
                HasMany(p => p.Descendientes)
                .WithOne(d => d.Ancestro)
               .HasForeignKey(d => d.AncestroId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EnumeradoJerarquia>()
             .HasKey(p => new { p.AncestroId, p.DescendienteId });





        }
       

#endregion

    }
}
