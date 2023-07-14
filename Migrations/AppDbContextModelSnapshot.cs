﻿// <auto-generated />
using System;
using CatalogoProductos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatalogoProductos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CatalogoProductos.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CatalogoProductos.Models.ImagenProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<string>("RutaImagen")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ImagenesProductos");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Tracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estatus")
                        .HasColumnType("text");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trackings");
                });

            modelBuilder.Entity("OrdenProducto", b =>
                {
                    b.Property<int>("OrdenesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductosId")
                        .HasColumnType("int");

                    b.HasKey("OrdenesId", "ProductosId");

                    b.HasIndex("ProductosId");

                    b.ToTable("OrdenProducto");
                });

            modelBuilder.Entity("CatalogoProductos.Models.ImagenProducto", b =>
                {
                    b.HasOne("CatalogoProductos.Models.Producto", "Producto")
                        .WithMany("Imagenes")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Orden", b =>
                {
                    b.HasOne("CatalogoProductos.Models.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Producto", b =>
                {
                    b.HasOne("CatalogoProductos.Models.Cliente", null)
                        .WithMany("Productos")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("OrdenProducto", b =>
                {
                    b.HasOne("CatalogoProductos.Models.Orden", null)
                        .WithMany()
                        .HasForeignKey("OrdenesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoProductos.Models.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CatalogoProductos.Models.Cliente", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("CatalogoProductos.Models.Producto", b =>
                {
                    b.Navigation("Imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}
