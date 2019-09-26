using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.Data
{
    public class ClientContext : DbContext 
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base (options)
        {

        }

        public DbSet<Client> Clients { get; set;  }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Cliente");
            modelBuilder.Entity<Contact>().ToTable("Contact");

            modelBuilder.Entity<Client>().Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Client>().Property(c => c.Nome)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Telefone)
                .HasColumnType("varchar(15)");
        }
    }
}
