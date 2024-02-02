﻿// <auto-generated />
using System;
using Agenda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agenda.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Agenda.Domain.Entities.Lista_Tarefas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Criação")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Listas_Tarefas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas a serem feitas em casa",
                            Tipo = "Casa"
                        },
                        new
                        {
                            Id = 2,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas relacionadas com trabalho",
                            Tipo = "Trabalho"
                        },
                        new
                        {
                            Id = 3,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas relacionadas com escola",
                            Tipo = "Escola"
                        },
                        new
                        {
                            Id = 4,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas dos mais pequenos",
                            Tipo = "Crianças"
                        },
                        new
                        {
                            Id = 5,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas relacionadas os patudos",
                            Tipo = "Animais"
                        },
                        new
                        {
                            Id = 6,
                            Criação = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrição = "Tarefas de lazer",
                            Tipo = "Lazer"
                        });
                });

            modelBuilder.Entity("Agenda.Domain.Entities.Tarefa", b =>
                {
                    b.Property<int>("Tarefa_")
                        .HasColumnType("int");

                    b.Property<string>("Defenição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lista_TarefasID")
                        .HasColumnType("int");

                    b.Property<int>("Prazo")
                        .HasColumnType("int");

                    b.Property<string>("Prioridade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tarefa_");

                    b.HasIndex("Lista_TarefasID");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("Agenda.Domain.Entities.Tarefa", b =>
                {
                    b.HasOne("Agenda.Domain.Entities.Lista_Tarefas", "Lista_Tarefas")
                        .WithMany()
                        .HasForeignKey("Lista_TarefasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lista_Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
