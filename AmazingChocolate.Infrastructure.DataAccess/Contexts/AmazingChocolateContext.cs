using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.ValueObjects;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingChocolate.Infrastructure.DataAccess.Contexts
{

    
    public class AmazingChocolateContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }



        public AmazingChocolateContext()
        {

        }

        public AmazingChocolateContext(DbContextOptions<AmazingChocolateContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Properties.Resources.
                ResourceManager.GetString("DbConnectionString"));



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


     

            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasMany(p => p.Itens); 
            
            modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Produto>().HasMany(p => p.ItemPedidos);

            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Cliente>().HasMany(p => p.Pedido);

        }

    }
}
