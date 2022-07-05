using System;
using Microsoft.EntityFrameworkCore;
using smk_travel.Models;

namespace smk_travel.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        
        public DbSet<Travel> Travels { get; set; }
        // public DbSet<Cliente> Clientes { get; set; }
        // public DbSet<Produto> Produtos { get; set; }
        // public DbSet<Pedido> Pedidos { get; set; }
        // public DbSet<PedidoProduto> PedidosProdutos { get; set; }
    }
}