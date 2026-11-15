using Microsoft.EntityFrameworkCore;
using Vendinha.Domain.Models;

namespace Vendinha.Infrastructure.Context
{
    public class VendinhaDbContext : DbContext
    {
        public VendinhaDbContext()
        {

        }

        public VendinhaDbContext(DbContextOptions opt) : base(opt)
        { }

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //---------------------Cliente-----------------------//

            var entityCliente = modelBuilder.Entity<Cliente>();

            entityCliente.ToTable("clientes");

            entityCliente.HasKey(c => c.CPF);
            entityCliente.Property(c => c.CPF)
                .HasColumnName("cpf");
            entityCliente.Property(c => c.Nome)
                .HasColumnName("nome")
                .IsRequired();
            entityCliente.Property(c => c.DataNascimento)
                .HasColumnName("datanascimento")
                .HasColumnType("date")
                .IsRequired();
            entityCliente.Property(d => d.DataInscricao)
                .HasColumnName("data_inscricao");
            entityCliente.Property(c => c.Email)
                .HasColumnName("email");


            // Relacionamento 1:N

            entityCliente
                .HasMany(c => c.Dividas)
                .WithOne(d => d.Cliente)
                .HasForeignKey(d => d.ClienteCPF)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            //---------------------Divida-----------------------//

            var entityDivida = modelBuilder.Entity<Divida>();

            entityDivida.ToTable("dividas");

            entityDivida.HasKey(d => d.id);

            entityDivida.Property(d => d.id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();
            entityDivida.Property(d => d.Valor)
                .HasColumnName("valor")
                .HasPrecision(18, 2);
            entityDivida.Property(d => d.Pago)
                .HasColumnName("status");
            entityDivida.Property(d => d.DataCriacao)
                .HasColumnName("data_criacao");
            entityDivida.Property(d => d.DataPagamento)
                .HasColumnName("data_pagamento");
            entityDivida.Property(d => d.ClienteCPF)
                .HasColumnName("cliente_cpf")
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                    "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=admin;"
                );
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
