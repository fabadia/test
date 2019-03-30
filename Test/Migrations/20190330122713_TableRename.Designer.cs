﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Data;

namespace Test.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190330122713_TableRename")]
    partial class TableRename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilialId");

                    b.Property<int>("ProdutoId");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Test.Models.Filial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("Test.Models.ItemPedidoEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoEstoqueId");

                    b.Property<int>("ProdutoId");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoEstoqueId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemPedidoEstoques");
                });

            modelBuilder.Entity("Test.Models.PedidoEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("FilialId");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.ToTable("PedidoEstoques");
                });

            modelBuilder.Entity("Test.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Test.Models.Estoque", b =>
                {
                    b.HasOne("Test.Models.Filial", "Filial")
                        .WithMany("Estoques")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test.Models.Produto", "Produto")
                        .WithMany("Estoques")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test.Models.ItemPedidoEstoque", b =>
                {
                    b.HasOne("Test.Models.PedidoEstoque", "PedidoEstoque")
                        .WithMany("ItemPedidoEstoques")
                        .HasForeignKey("PedidoEstoqueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test.Models.Produto", "Produto")
                        .WithMany("ItemPedidoEstoques")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test.Models.PedidoEstoque", b =>
                {
                    b.HasOne("Test.Models.Filial", "Filial")
                        .WithMany("PedidoEstoques")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
