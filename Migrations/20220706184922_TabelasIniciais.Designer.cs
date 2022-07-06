﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using smk_travel.Servicos.Database;

#nullable disable

namespace smk_travel.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20220706184922_TabelasIniciais")]
    partial class TabelasIniciais
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("smk_travel.Models.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("administradores");
                });

            modelBuilder.Entity("smk_travel.Models.Alojamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("morada");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("responsavel");

                    b.HasKey("Id");

                    b.ToTable("alojamentos");
                });

            modelBuilder.Entity("smk_travel.Models.CentroDeCusto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("centro_de_custos");
                });

            modelBuilder.Entity("smk_travel.Models.CompanhiaAerea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("CompanhiaAereas");
                });

            modelBuilder.Entity("smk_travel.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("departamentos");
                });

            modelBuilder.Entity("smk_travel.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CentroDeCustoId")
                        .HasColumnType("int")
                        .HasColumnName("centroDeCustoId");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int")
                        .HasColumnName("departamentoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("CentroDeCustoId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("smk_travel.Models.Itinerario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("itinerarios");
                });

            modelBuilder.Entity("smk_travel.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlojamentoId")
                        .HasColumnType("int")
                        .HasColumnName("alojamentoId");

                    b.Property<string>("Comentarios")
                        .IsRequired()
                        .HasColumnType("Text")
                        .HasColumnName("comentarios");

                    b.Property<int>("CompanhiaAereaId")
                        .HasColumnType("int")
                        .HasColumnName("CompanhiaAereaId");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataAtualizacao");

                    b.Property<DateTime>("DataChagada")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataChagada");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataCriacao");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataSaida");

                    b.Property<int>("DiasDeTrabalho")
                        .HasColumnType("int")
                        .HasColumnName("diasDeTrabalho");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("funcionarioId");

                    b.Property<bool>("Hospede")
                        .HasColumnType("bit")
                        .HasColumnName("hospede");

                    b.Property<int>("ItinerarioId")
                        .HasColumnType("int")
                        .HasColumnName("itinerarioId");

                    b.Property<bool>("TesteCovid")
                        .HasColumnType("bit")
                        .HasColumnName("testeCovid");

                    b.HasKey("Id");

                    b.HasIndex("AlojamentoId");

                    b.HasIndex("CompanhiaAereaId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ItinerarioId");

                    b.ToTable("viagens");
                });

            modelBuilder.Entity("smk_travel.Models.Funcionario", b =>
                {
                    b.HasOne("smk_travel.Models.CentroDeCusto", "CentroDeCusto")
                        .WithMany()
                        .HasForeignKey("CentroDeCustoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CentroDeCusto");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("smk_travel.Models.Viagem", b =>
                {
                    b.HasOne("smk_travel.Models.Alojamento", "Alojamento")
                        .WithMany()
                        .HasForeignKey("AlojamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.CompanhiaAerea", "CompanhiaAerea")
                        .WithMany()
                        .HasForeignKey("CompanhiaAereaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Itinerario", "Itinerario")
                        .WithMany()
                        .HasForeignKey("ItinerarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alojamento");

                    b.Navigation("CompanhiaAerea");

                    b.Navigation("Funcionario");

                    b.Navigation("Itinerario");
                });
#pragma warning restore 612, 618
        }
    }
}