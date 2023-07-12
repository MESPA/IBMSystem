using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProductos.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<ImagenProducto> ImagenesProductos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagenProducto>()
           .HasOne(ip => ip.Producto)
           .WithMany(p => p.Imagenes)
           .HasForeignKey(ip => ip.ProductoId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Orden>()
                .HasOne(o => o.Cliente)
                .WithMany(c => c.Ordenes)
                .HasForeignKey(o => o.ClienteId);


            // Configuración de relaciones entre entidades

        }
    }
}

