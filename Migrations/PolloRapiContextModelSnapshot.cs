﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolloRapiApi.Data;

#nullable disable

namespace PolloRapiApi.Migrations
{
    [DbContext(typeof(PolloRapiContext))]
    partial class PolloRapiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PolloRapiApi.Models.Comprobante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CuentasId")
                        .HasColumnType("int");

                    b.Property<int?>("MedioPagoId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuentasId");

                    b.HasIndex("MedioPagoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Comprobantes", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.Cuentas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cuentas", (string)null);
                });

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

                    b.ToTable("Enumerado", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.EnumeradoJerarquia", b =>
                {
                    b.Property<int?>("AncestroId")
                        .HasColumnType("int");

                    b.Property<int?>("DescendienteId")
                        .HasColumnType("int");

                    b.HasKey("AncestroId", "DescendienteId");

                    b.HasIndex("DescendienteId");

                    b.ToTable("EnumeradoJerarquias", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EnumeradoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("EnumeradoId");

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.PedidoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("EnumeradoId")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("PromocionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnumeradoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("PromocionId");

                    b.ToTable("PedidoDetalles", (string)null);
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

                    b.ToTable("Productos", (string)null);
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

                    b.ToTable("ProductoPromociones", (string)null);
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

                    b.ToTable("Promociones", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distrito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("PolloRapiApi.Models.Comprobante", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Cuentas", "Cuentas")
                        .WithMany()
                        .HasForeignKey("CuentasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Enumerado", "MedioPago")
                        .WithMany("TipoDocumentos")
                        .HasForeignKey("MedioPagoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PolloRapiApi.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Enumerado", "TipoDocumento")
                        .WithMany("MedioPagos")
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cuentas");

                    b.Navigation("MedioPago");

                    b.Navigation("Pedido");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Cuentas", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Usuario", "Usuario")
                        .WithMany("Cuentas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
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

            modelBuilder.Entity("PolloRapiApi.Models.Pedido", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Enumerado", "Estado")
                        .WithMany("Pedidos")
                        .HasForeignKey("EnumeradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("PolloRapiApi.Models.PedidoDetalle", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Enumerado", "Enumerado")
                        .WithMany()
                        .HasForeignKey("EnumeradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Pedido", "Pedido")
                        .WithMany("PedidoDetalles")
                        .HasForeignKey("PedidoId");

                    b.HasOne("PolloRapiApi.Models.Producto", "Producto")
                        .WithMany("PedidoDetalles")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolloRapiApi.Models.Promocion", "Promocion")
                        .WithMany("PedidoDetalles")
                        .HasForeignKey("PromocionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enumerado");

                    b.Navigation("Pedido");

                    b.Navigation("Producto");

                    b.Navigation("Promocion");
                });

            modelBuilder.Entity("PolloRapiApi.Models.ProductoPromocion", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Enumerado", "Estado")
                        .WithMany("ProductoPromociones")
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

            modelBuilder.Entity("PolloRapiApi.Models.Usuario", b =>
                {
                    b.HasOne("PolloRapiApi.Models.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Enumerado", b =>
                {
                    b.Navigation("Ancestros");

                    b.Navigation("Descendientes");

                    b.Navigation("MedioPagos");

                    b.Navigation("Pedidos");

                    b.Navigation("ProductoPromociones");

                    b.Navigation("TipoDocumentos");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Pedido", b =>
                {
                    b.Navigation("PedidoDetalles");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Producto", b =>
                {
                    b.Navigation("PedidoDetalles");

                    b.Navigation("ProductoPromociones");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Promocion", b =>
                {
                    b.Navigation("PedidoDetalles");

                    b.Navigation("ProductoPromociones");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("PolloRapiApi.Models.Usuario", b =>
                {
                    b.Navigation("Cuentas");
                });
#pragma warning restore 612, 618
        }
    }
}
