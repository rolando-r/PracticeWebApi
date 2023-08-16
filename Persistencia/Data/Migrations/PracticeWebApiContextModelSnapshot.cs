﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(PracticeWebApiContext))]
    partial class PracticeWebApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Property<string>("IdCiudad")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DepartamentoIdDep")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdDepFk")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("longtext");

                    b.HasKey("IdCiudad");

                    b.HasIndex("DepartamentoIdDep");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Property<string>("IdDep")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdPaisFk")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreDep")
                        .HasColumnType("longtext");

                    b.Property<string>("PaisIdPais")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdDep");

                    b.HasIndex("PaisIdPais");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Dominio.Direccion", b =>
                {
                    b.Property<string>("IdDireccion")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("longtext");

                    b.Property<string>("Letra")
                        .HasColumnType("longtext");

                    b.Property<string>("LetraViaSecundaria")
                        .HasColumnType("longtext");

                    b.Property<int>("NroViaSecundaria")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("PersonaIdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SufijoCardinal")
                        .HasColumnType("longtext");

                    b.Property<string>("SufijoCards")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoVia")
                        .HasColumnType("longtext");

                    b.HasKey("IdDireccion");

                    b.HasIndex("PersonaIdPersona");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionGenero")
                        .HasColumnType("longtext");

                    b.HasKey("IdGenero");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.Property<int>("IdMatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("longtext");

                    b.Property<string>("IdSalonFk")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonaIdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("SalonIdSalon")
                        .HasColumnType("int");

                    b.HasKey("IdMatricula");

                    b.HasIndex("PersonaIdPersona");

                    b.HasIndex("SalonIdSalon");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Property<string>("IdPais")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombrePais")
                        .HasColumnType("longtext");

                    b.HasKey("IdPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<string>("IdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("CiudadIdCiudad")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("GeneroIdGenero")
                        .HasColumnType("int");

                    b.Property<string>("IdCiudadFk")
                        .HasColumnType("longtext");

                    b.Property<string>("IdGeneroFk")
                        .HasColumnType("longtext");

                    b.Property<string>("IdTipoPerFk")
                        .HasColumnType("longtext");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("longtext");

                    b.Property<int?>("TipoPersonaIdTipoPersona")
                        .HasColumnType("int");

                    b.HasKey("IdPersona");

                    b.HasIndex("CiudadIdCiudad");

                    b.HasIndex("GeneroIdGenero");

                    b.HasIndex("TipoPersonaIdTipoPersona");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Property<int>("IdSalon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CapacidadSalon")
                        .HasColumnType("int");

                    b.Property<string>("NombreSalon")
                        .HasColumnType("longtext");

                    b.HasKey("IdSalon");

                    b.ToTable("Salones");
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Property<int>("IdTipoPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionTipoPersona")
                        .HasColumnType("longtext");

                    b.HasKey("IdTipoPersona");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.Property<string>("IdPerTrainerFk")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdSalonFk")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonaIdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("SalonIdSalon")
                        .HasColumnType("int");

                    b.HasKey("IdPerTrainerFk");

                    b.HasIndex("PersonaIdPersona");

                    b.HasIndex("SalonIdSalon");

                    b.ToTable("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.HasOne("Dominio.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentoIdDep");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.HasOne("Dominio.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("PaisIdPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Direccion", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("Direcciones")
                        .HasForeignKey("PersonaIdPersona");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("Matriculas")
                        .HasForeignKey("PersonaIdPersona");

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("Matriculas")
                        .HasForeignKey("SalonIdSalon");

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.HasOne("Dominio.Ciudad", "Ciudad")
                        .WithMany("Personas")
                        .HasForeignKey("CiudadIdCiudad");

                    b.HasOne("Dominio.Genero", "Genero")
                        .WithMany("Personas")
                        .HasForeignKey("GeneroIdGenero");

                    b.HasOne("Dominio.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("TipoPersonaIdTipoPersona");

                    b.Navigation("Ciudad");

                    b.Navigation("Genero");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("PersonaIdPersona");

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("SalonIdSalon");

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
