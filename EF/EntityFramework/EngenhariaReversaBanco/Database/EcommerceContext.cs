
using System;
using System.Collections.Generic;
using EngenhariaReversaBanco.Models;
using Microsoft.EntityFrameworkCore;

namespace EngenhariaReversaBanco.Database;

public partial class EcommerceContext : DbContext
{
    public EcommerceContext()
    {
    }

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contato> Contatos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Endereco> Enderecos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ecommerce;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contato>(entity =>
        {
            entity.HasIndex(e => e.UsuarioId, "IX_Contatos_UsuarioId").IsUnique();

            entity.HasOne(d => d.Usuario).WithOne(p => p.Contato).HasForeignKey<Contato>(d => d.UsuarioId);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasMany(d => d.ListaUsuarios).WithMany(p => p.ListaDepartamentos)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartamentoUsuario",
                    r => r.HasOne<Usuario>().WithMany().HasForeignKey("ListaUsuariosId"),
                    l => l.HasOne<Departamento>().WithMany().HasForeignKey("ListaDepartamentosId"),
                    j =>
                    {
                        j.HasKey("ListaDepartamentosId", "ListaUsuariosId");
                        j.ToTable("DepartamentoUsuario");
                        j.HasIndex(new[] { "ListaUsuariosId" }, "IX_DepartamentoUsuario_ListaUsuariosId");
                    });
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasIndex(e => e.UsuarioId, "IX_Enderecos_UsuarioId");

            entity.Property(e => e.Cep).HasColumnName("CEP");
            entity.Property(e => e.Endereco1).HasColumnName("Endereco");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Enderecos).HasForeignKey(d => d.UsuarioId);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Cpf).HasColumnName("CPF");
            entity.Property(e => e.Rg).HasColumnName("RG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
