using Microsoft.EntityFrameworkCore;
using RelacaoManyToMany.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacaoManyToMany
{
    internal class TomanyContext : DbContext
    {
        public DbSet<Colaborador>? Colaboradores { get; set; }
        public DbSet<ColaboradorSetor> ColaSetor { get; set; }
        public DbSet<Setor>? Setores { get; set; }
        public DbSet<Turma>? Turmas { get; set; }
        public DbSet<Veiculo>? Veiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EcommerceMany;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColaboradorSetor>().HasKey(x => new {x.SetorId,x.ColaboradorId});

            //modelBuilder.Entity<ColaboradorSetor>().HasOne(x => x.Colaborador).WithMany(x => x.ColaboradorSetor).HasForeignKey(x => x.ColaboradorId);
            //    modelBuilder.Entity<ColaboradorSetor>().HasOne(x => x.Setor).WithMany(x => x.ColaboradorSetor).HasForeignKey(x => x.SetorId);
            ////modelBuilder.Entity<Colaborador>().HasMany(x => x.ColaboradorSetor).WithOne(x => x.Colaborador).HasForeignKey(x => x.ColaboradorId);
            ////modelBuilder.Entity<Setor>().HasMany(x => x.ColaboradorSetor).WithOne(x => x.Setor).HasForeignKey(x => x.SetorId);

            //modelBuilder.Entity<Setor>().HasData(new Setor { Id = 1,Nome = "Depósito" }, new Setor { Id = 2,Nome = "Faturamento" });
            //modelBuilder.Entity<ColaboradorSetor>().HasData(new ColaboradorSetor { SetorId = 1, ColaboradorId = 2 });
            modelBuilder.Entity<Colaborador>().HasMany(x => x.Turmas).WithMany(x => x.Colaboradores);
           modelBuilder.Entity<Turma>().HasData(new Turma() { Id = 1, Nome = "Engenharia" },new Turma() { Id = 2,Nome = "Logística"});
           modelBuilder.Entity<Colaborador>().HasData(new Colaborador() { Id = 1, Nome = "Amarildo" },new Colaborador() { Id = 2,Nome = "Maria"});

        }
    }
}
