﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.Persistencia;

#nullable disable

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContextS))]
    [Migration("20230926191230_Primera")]
    partial class Primera
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto.Dominio.Establecimientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiciosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiciosId");

                    b.ToTable("Establecimientos");
                });

            modelBuilder.Entity("Proyecto.Dominio.Manzanas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Registro_CuidadoraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("Registro_CuidadoraId");

                    b.ToTable("Manzanas");
                });

            modelBuilder.Entity("Proyecto.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Proyecto.Dominio.Registro_Cuidadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registro_Cuidadoras");
                });

            modelBuilder.Entity("Proyecto.Dominio.Servicios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManzanasId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManzanasId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Proyecto.Dominio.UsuarioMujeres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Ocupación")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuarioMujeres");
                });

            modelBuilder.Entity("Proyecto.Dominio.Establecimientos", b =>
                {
                    b.HasOne("Proyecto.Dominio.Servicios", null)
                        .WithMany("Establecimientos")
                        .HasForeignKey("ServiciosId");
                });

            modelBuilder.Entity("Proyecto.Dominio.Manzanas", b =>
                {
                    b.HasOne("Proyecto.Dominio.Municipio", null)
                        .WithMany("Manzanas")
                        .HasForeignKey("MunicipioId");

                    b.HasOne("Proyecto.Dominio.Registro_Cuidadora", null)
                        .WithMany("Manzanas")
                        .HasForeignKey("Registro_CuidadoraId");
                });

            modelBuilder.Entity("Proyecto.Dominio.Servicios", b =>
                {
                    b.HasOne("Proyecto.Dominio.Manzanas", null)
                        .WithMany("Servicios")
                        .HasForeignKey("ManzanasId");
                });

            modelBuilder.Entity("Proyecto.Dominio.Manzanas", b =>
                {
                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("Proyecto.Dominio.Municipio", b =>
                {
                    b.Navigation("Manzanas");
                });

            modelBuilder.Entity("Proyecto.Dominio.Registro_Cuidadora", b =>
                {
                    b.Navigation("Manzanas");
                });

            modelBuilder.Entity("Proyecto.Dominio.Servicios", b =>
                {
                    b.Navigation("Establecimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
