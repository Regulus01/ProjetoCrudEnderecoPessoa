﻿// <auto-generated />
using System;
using CrudPessoaEndereco.PessoaAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudPessoaEndereco.PessoaAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CadastroPessoaEndereco.PessoaAPI.Model.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Bairro");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Cep");

                    b.Property<string>("Cidade")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Cidade");

                    b.Property<string>("EstadoUf")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("Estado");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Logradouro");

                    b.Property<string>("Numero")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Numero");

                    b.Property<Guid?>("PessoaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CadastroPessoaEndereco.PessoaAPI.Model.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("CadastroPessoaEndereco.PessoaAPI.Model.Endereco", b =>
                {
                    b.HasOne("CadastroPessoaEndereco.PessoaAPI.Model.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("CadastroPessoaEndereco.PessoaAPI.Model.Endereco", "PessoaId");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("CadastroPessoaEndereco.PessoaAPI.Model.Pessoa", b =>
                {
                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
