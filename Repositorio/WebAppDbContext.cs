using System;
using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository
{
    
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<TipoProduto> TipoProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
