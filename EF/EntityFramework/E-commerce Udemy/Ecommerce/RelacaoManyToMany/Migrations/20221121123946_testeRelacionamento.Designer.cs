﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelacaoManyToMany;

#nullable disable

namespace RelacaoManyToMany.Migrations
{
    [DbContext(typeof(TomanyContext))]
    [Migration("20221121123946_testeRelacionamento")]
    partial class testeRelacionamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "TurmasId");

                    b.HasIndex("TurmasId");

                    b.ToTable("ColaboradorTurma");
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.Property<int>("VeiculosId")
                        .HasColumnType("int");

                    b.Property<int>("colaboradoresId")
                        .HasColumnType("int");

                    b.HasKey("VeiculosId", "colaboradoresId");

                    b.HasIndex("colaboradoresId");

                    b.ToTable("ColaboradorVeiculo");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.ColaboradorSetor", b =>
                {
                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.HasKey("SetorId", "ColaboradorId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("ColaSetor");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.HasOne("RelacaoManyToMany.Modelos.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelacaoManyToMany.Modelos.Turma", null)
                        .WithMany()
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.HasOne("RelacaoManyToMany.Modelos.Veiculo", null)
                        .WithMany()
                        .HasForeignKey("VeiculosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelacaoManyToMany.Modelos.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("colaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.ColaboradorSetor", b =>
                {
                    b.HasOne("RelacaoManyToMany.Modelos.Colaborador", "Colaborador")
                        .WithMany("ColaboradorSetor")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelacaoManyToMany.Modelos.Setor", "Setor")
                        .WithMany("ColaboradorSetor")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Colaborador", b =>
                {
                    b.Navigation("ColaboradorSetor");
                });

            modelBuilder.Entity("RelacaoManyToMany.Modelos.Setor", b =>
                {
                    b.Navigation("ColaboradorSetor");
                });
#pragma warning restore 612, 618
        }
    }
}
