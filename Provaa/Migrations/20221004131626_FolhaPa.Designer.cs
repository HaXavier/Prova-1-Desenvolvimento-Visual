// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Folha.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221004131626_FolhaPa")]
    partial class FolhaPa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuncionarioId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FuncionarioId1")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Impostofgts")
                        .HasColumnType("REAL");

                    b.Property<double>("Impostoinss")
                        .HasColumnType("REAL");

                    b.Property<double>("Impostorenda")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantidadehoras")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Salariobruto")
                        .HasColumnType("REAL");

                    b.Property<double>("Salarioliquido")
                        .HasColumnType("REAL");

                    b.Property<double>("Valorhora")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId1");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("API.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salario")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("API.Models.FolhaPagamento", b =>
                {
                    b.HasOne("API.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId1");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
