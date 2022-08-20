﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolloRapiApi.Data;

#nullable disable

namespace PolloRapiApi.Migrations
{
    [DbContext(typeof(PolloRapiContext))]
    [Migration("20220820024043_EnumeradoAgregado")]
    partial class EnumeradoAgregado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PolloRapiApi.Models.Enumerado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enumerado");
                });

            modelBuilder.Entity("PolloRapiApi.Models.EnumeradoJerarquia", b =>
                {
                    b.Property<int?>("AncestroId")
                        .HasColumnType("int");

                    b.Property<int?>("DescendienteId")
                        .HasColumnType("int");

                    b.HasKey("AncestroId", "DescendienteId");

                    b.HasIndex("DescendienteId");

                    b.ToTable("EnumeradoJerarquia");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioBruto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioNeto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PolloRapiApi.Models.ProductoPromocion", b =>
                {
                    b.Property<int>("ProductoPromocionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoPromocionId"), 1L, 1);

                    b.Property<int>("EnumeradoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("PromocionId")
                        .HasColumnType("int");

                    b.HasKey("ProductoPromocionId");

                    b.HasIndex("EnumeradoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("PromocionId");

                    b.ToTable("ProductoPromociones");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Promocion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Promociones");
                });

            modelBuilder.Entity("PolloRapiApi.Models.EnumeradoJerarquia", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Enumerado", "Ancestro")
                        .WithMany("Descendientes")
                        .HasForeignKey("AncestroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Enumerado", "Descendiente")
                        .WithMany("Ancestros")
                        .HasForeignKey("DescendienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ancestro");

                    b.Navigation("Descendiente");
                });

            modelBuilder.Entity("PolloRapiApi.Models.ProductoPromocion", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Enumerado", "Estado")
                        .WithMany()
                        .HasForeignKey("EnumeradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Producto", "Producto")
                        .WithMany("ProductoPromociones")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Promocion", "Promocion")
                        .WithMany("ProductoPromociones")
                        .HasForeignKey("PromocionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Producto");

                    b.Navigation("Promocion");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Enumerado", b =>
                {
                    b.Navigation("Ancestros");

                    b.Navigation("Descendientes");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Producto", b =>
                {
                    b.Navigation("ProductoPromociones");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Promocion", b =>
                {
                    b.Navigation("ProductoPromociones");
                });
#pragma warning restore 612, 618
        }
    }
}