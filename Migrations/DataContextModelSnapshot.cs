﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gestorFinanceiro.Data;

#nullable disable

namespace gestorFinanceiro.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("gestorFinanceiro.Models.Banco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.ContaFinanceira", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("IdBanco")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoConta")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("ContasFinanceiras");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.Lancamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CodigoRelacao")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataTransacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<bool>("DespesaFixa")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoSituacaoTransacao")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoTransacao")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Lancamentos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Lancamento");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("gestorFinanceiro.Models.SituacaoTransacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("SituacoesTransacao");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.TipoConta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("TiposConta");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.TipoTransacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("TiposTransacao");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Apelido")
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.LancamentoCartaoCredito", b =>
                {
                    b.HasBaseType("gestorFinanceiro.Models.Lancamento");

                    b.Property<int>("IdCartaoCredito")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("LancamentoCartaoCredito");
                });

            modelBuilder.Entity("gestorFinanceiro.Models.LancamentoConta", b =>
                {
                    b.HasBaseType("gestorFinanceiro.Models.Lancamento");

                    b.Property<DateTime>("DataBaixa")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdBanco")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("LancamentoConta");
                });
#pragma warning restore 612, 618
        }
    }
}
