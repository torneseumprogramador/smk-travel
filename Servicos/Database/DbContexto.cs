using System;
using Microsoft.EntityFrameworkCore;
using smk_travel.Models;

namespace smk_travel.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Alojamento> Alojamentos { get; set; }
        public DbSet<CentroDeCusto> CentroDeCustos { get; set; }
        public DbSet<CompanhiaAerea> CompanhiaAereas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<EstadoDaViagem> EstadoDaViagens { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Motivo> Motivos { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<TipoDeBilhete> TipoDeBilhetes { get; set; }
        public DbSet<smk_travel.Models.Entidade> Entidades { get; set; }
        public DbSet<smk_travel.Models.Profissao> Profissoes { get; set; }
        public DbSet<smk_travel.Models.SituacaoViagem> SituacaoViagens { get; set; }
        public DbSet<smk_travel.Models.ArquivoDeFuncionario> ArquivoDeFuncionarios { get; set; }

    }
}