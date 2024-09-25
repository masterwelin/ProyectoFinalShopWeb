using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Shop.Web.Data.Entities;
using Shop.Web.Data.Interfaces;

namespace Shop.Web.Data.Context
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options): base(options) 
        {
             
        }

        public DbSet<Employees> Employees { get; set; }
        //public DbSet<Customers> Customers { get; set; }
        //public DbSet<Shippers> Shippers { get; set; }
        //public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la clave primaria de la tabla
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.empid); // La clave primaria
                entity.Property(e => e.lastname).IsRequired().HasMaxLength(20);
                entity.Property(e => e.firstname).IsRequired().HasMaxLength(10);
                // Aquí puedes continuar configurando las propiedades según los detalles de la tabla...
            });
        }

    }
}
