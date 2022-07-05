using System;
using Microsoft.EntityFrameworkCore;
using smk_travel.Models;

namespace smk_travel.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        
        public DbSet<Travel> Travels { get; set; }
    }
}