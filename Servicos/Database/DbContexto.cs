using System;
using Microsoft.EntityFrameworkCore;
using smk_travel.Models;

namespace smk_travel.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        
        public DbSet<Alojamento> Alojamentos { get; set; }
        public DbSet<CentroDeCusto> CentroDeCustos { get; set; }
        public DbSet<CompanhiaAeria> CompanhiaAerias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}