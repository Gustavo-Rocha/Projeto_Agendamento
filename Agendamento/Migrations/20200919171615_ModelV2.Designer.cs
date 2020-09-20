﻿// <auto-generated />
using System;
using Agendamento.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agendamento.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200919171615_ModelV2")]
    partial class ModelV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agendamento.Models.Agenda", b =>
                {
                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("Data");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Agendamento.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cpf");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}