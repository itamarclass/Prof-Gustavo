﻿// <auto-generated />
using System;
using AmazingChocolate.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmazingChocolate.Infrastructure.DataAccess.Migrations
{
    [DbContext(typeof(AmazingChocolateContext))]
    [Migration("20190623150437_InicialAzure")]
    partial class InicialAzure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("Complemento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Municipio");

                    b.Property<string>("NomeCliente");

                    b.Property<string>("Telefone");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.ItemPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PedidoId");

                    b.Property<decimal>("PrecoUnitario");

                    b.Property<Guid?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemPedidos");
                });

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FotoProdutoURL");

                    b.Property<string>("NomeProduto");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.Cliente", b =>
                {
                    b.HasOne("AmazingChocolate.DomainModel.Entities.Pedido", "Pedido")
                        .WithOne("Cliente")
                        .HasForeignKey("AmazingChocolate.DomainModel.Entities.Cliente", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AmazingChocolate.DomainModel.Entities.ItemPedido", b =>
                {
                    b.HasOne("AmazingChocolate.DomainModel.Entities.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId");

                    b.HasOne("AmazingChocolate.DomainModel.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}
