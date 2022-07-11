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
    [Migration("20220711183800_ArquivoDeFuncionario")]
    partial class ArquivoDeFuncionario
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

            modelBuilder.Entity("smk_travel.Models.ArquivoDeFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Arquivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("arquivo");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("funcionarioId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("arquivoDeFuncionarios");
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

                    b.ToTable("centroDeCustos");
                });

            modelBuilder.Entity("smk_travel.Models.Classe", b =>
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

                    b.ToTable("classes");
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

                    b.ToTable("companhiaAereas");
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

                    b.Property<int?>("FuncionarioRepresentanteId")
                        .HasColumnType("int")
                        .HasColumnName("funcionarioRepresentanteId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("departamentos");
                });

            modelBuilder.Entity("smk_travel.Models.Entidade", b =>
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

                    b.ToTable("entidades");
                });

            modelBuilder.Entity("smk_travel.Models.EstadoDaViagem", b =>
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

                    b.ToTable("estadoDaViagens");
                });

            modelBuilder.Entity("smk_travel.Models.Fornecedor", b =>
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
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("morada");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nif");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("fornecedores");
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

                    b.Property<int>("EntidadeId")
                        .HasColumnType("int")
                        .HasColumnName("entidadeId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("nome");

                    b.Property<int>("ProfissaoId")
                        .HasColumnType("int")
                        .HasColumnName("profissaoId");

                    b.HasKey("Id");

                    b.HasIndex("CentroDeCustoId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("EntidadeId");

                    b.HasIndex("ProfissaoId");

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

            modelBuilder.Entity("smk_travel.Models.Motivo", b =>
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

                    b.ToTable("motivos");
                });

            modelBuilder.Entity("smk_travel.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentarios")
                        .IsRequired()
                        .HasColumnType("Text")
                        .HasColumnName("comentarios");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

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

                    b.Property<DateTime>("DataSolicitacaoFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataSolicitacaoFim");

                    b.Property<DateTime>("DataSolicitacaoInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataSolicitacaoInicio");

                    b.Property<int>("DiasDeTrabalho")
                        .HasColumnType("int")
                        .HasColumnName("diasDeTrabalho");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("funcionarioId");

                    b.Property<int>("ItinerarioId")
                        .HasColumnType("int")
                        .HasColumnName("itinerarioId");

                    b.Property<int>("MotivoId")
                        .HasColumnType("int")
                        .HasColumnName("motivoId");

                    b.Property<int>("SiteId")
                        .HasColumnType("int")
                        .HasColumnName("siteId");

                    b.Property<bool>("TesteCovid")
                        .HasColumnType("bit")
                        .HasColumnName("testeCovid");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ItinerarioId");

                    b.HasIndex("MotivoId");

                    b.HasIndex("SiteId");

                    b.ToTable("processos");
                });

            modelBuilder.Entity("smk_travel.Models.Profissao", b =>
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

                    b.ToTable("profissoes");
                });

            modelBuilder.Entity("smk_travel.Models.Site", b =>
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

                    b.ToTable("sites");
                });

            modelBuilder.Entity("smk_travel.Models.SituacaoViagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("situacao");

                    b.Property<int>("ViagemId")
                        .HasColumnType("int")
                        .HasColumnName("ViagemId");

                    b.HasKey("Id");

                    b.HasIndex("ViagemId");

                    b.ToTable("SituacaoViagens");
                });

            modelBuilder.Entity("smk_travel.Models.TipoDeBilhete", b =>
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

                    b.ToTable("tipoDeBilhetes");
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

                    b.Property<string>("Arquivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("arquivo");

                    b.Property<int>("Classeid")
                        .HasColumnType("int")
                        .HasColumnName("classeId");

                    b.Property<string>("Comentarios")
                        .IsRequired()
                        .HasColumnType("Text")
                        .HasColumnName("comentarios");

                    b.Property<int>("CompanhiaAereaId")
                        .HasColumnType("int")
                        .HasColumnName("CompanhiaAereaId");

                    b.Property<double>("CustoBilhete")
                        .HasColumnType("float")
                        .HasColumnName("custoBilhete");

                    b.Property<double>("CustoNoShow")
                        .HasColumnType("float")
                        .HasColumnName("custoNoShow");

                    b.Property<double>("CustoReemissao")
                        .HasColumnType("float")
                        .HasColumnName("custoReemissao");

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

                    b.Property<DateTime>("DataSolicitacaoFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataSolicitacaoFim");

                    b.Property<DateTime>("DataSolicitacaoInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataSolicitacaoInicio");

                    b.Property<int>("DiasDeTrabalho")
                        .HasColumnType("int")
                        .HasColumnName("diasDeTrabalho");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("documento");

                    b.Property<int>("EstadoDaViagemId")
                        .HasColumnType("int")
                        .HasColumnName("estadoDaViagemId");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("funcionarioId");

                    b.Property<bool>("Hospede")
                        .HasColumnType("bit")
                        .HasColumnName("hospede");

                    b.Property<int>("ItinerarioId")
                        .HasColumnType("int")
                        .HasColumnName("itinerarioId");

                    b.Property<int>("MotivoId")
                        .HasColumnType("int")
                        .HasColumnName("motivoId");

                    b.Property<string>("NumeroBilhete")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("numeroBilhete");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int")
                        .HasColumnName("processoId");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("referencia");

                    b.Property<double>("TaxaReembolso")
                        .HasColumnType("float")
                        .HasColumnName("taxaReembolso");

                    b.Property<bool>("TesteCovid")
                        .HasColumnType("bit")
                        .HasColumnName("testeCovid");

                    b.Property<int>("TipoDeBilheteId")
                        .HasColumnType("int")
                        .HasColumnName("tipoDeBilheteId");

                    b.Property<double>("TotalBilhete")
                        .HasColumnType("float")
                        .HasColumnName("totalBilhete");

                    b.HasKey("Id");

                    b.HasIndex("AlojamentoId");

                    b.HasIndex("Classeid");

                    b.HasIndex("CompanhiaAereaId");

                    b.HasIndex("EstadoDaViagemId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ItinerarioId");

                    b.HasIndex("MotivoId");

                    b.HasIndex("ProcessoId");

                    b.HasIndex("TipoDeBilheteId");

                    b.ToTable("viagens");
                });

            modelBuilder.Entity("smk_travel.Models.ArquivoDeFuncionario", b =>
                {
                    b.HasOne("smk_travel.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
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

                    b.HasOne("smk_travel.Models.Entidade", "Entidade")
                        .WithMany()
                        .HasForeignKey("EntidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Profissao", "Profissao")
                        .WithMany()
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CentroDeCusto");

                    b.Navigation("Departamento");

                    b.Navigation("Entidade");

                    b.Navigation("Profissao");
                });

            modelBuilder.Entity("smk_travel.Models.Processo", b =>
                {
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

                    b.HasOne("smk_travel.Models.Motivo", "Motivo")
                        .WithMany()
                        .HasForeignKey("MotivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Itinerario");

                    b.Navigation("Motivo");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("smk_travel.Models.SituacaoViagem", b =>
                {
                    b.HasOne("smk_travel.Models.Viagem", "Viagem")
                        .WithMany()
                        .HasForeignKey("ViagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("smk_travel.Models.Viagem", b =>
                {
                    b.HasOne("smk_travel.Models.Alojamento", "Alojamento")
                        .WithMany()
                        .HasForeignKey("AlojamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("Classeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.CompanhiaAerea", "CompanhiaAerea")
                        .WithMany()
                        .HasForeignKey("CompanhiaAereaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.EstadoDaViagem", "EstadoDaViagem")
                        .WithMany()
                        .HasForeignKey("EstadoDaViagemId")
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

                    b.HasOne("smk_travel.Models.Motivo", "Motivo")
                        .WithMany()
                        .HasForeignKey("MotivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smk_travel.Models.TipoDeBilhete", "TipoDeBilhete")
                        .WithMany()
                        .HasForeignKey("TipoDeBilheteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alojamento");

                    b.Navigation("Classe");

                    b.Navigation("CompanhiaAerea");

                    b.Navigation("EstadoDaViagem");

                    b.Navigation("Funcionario");

                    b.Navigation("Itinerario");

                    b.Navigation("Motivo");

                    b.Navigation("Processo");

                    b.Navigation("TipoDeBilhete");
                });
#pragma warning restore 612, 618
        }
    }
}
