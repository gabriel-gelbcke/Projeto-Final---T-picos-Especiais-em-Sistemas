﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoBiblioteca.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20240519041126_oito9")]
    partial class oito9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Emprestimo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDevolucao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataEmprestimo")
                        .HasColumnType("TEXT");

                    b.Property<string>("LivroId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("Livro", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AnoPublicacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Emprestimo", b =>
                {
                    b.HasOne("Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
