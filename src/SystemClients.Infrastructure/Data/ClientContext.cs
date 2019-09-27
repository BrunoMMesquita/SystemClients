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

            modelBuilder.Entity<Client>().HasKey(c => c.ClientId);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Contacts)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId);

            modelBuilder.Entity<Client>().Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Client>().Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Client)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId);

            modelBuilder.Entity<Contact>().Property(c => c.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Telefone)
                .HasColumnType("varchar(15)");

            modelBuilder.Entity<Profession>().Property(c => c.Name)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profession>().Property(c => c.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profession>().Property(c => c.Description)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            modelBuilder.Entity<Adress>().Property(c => c.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Adress>().Property(c => c.Cep)
              .HasColumnType("varchar(15)")
              .IsRequired();

            modelBuilder.Entity<Adress>().Property(c => c.Logradouro)
              .HasColumnType("varchar(200)")
              .IsRequired();

            modelBuilder.Entity<Adress>().Property(c => c.Referencia)
           .HasColumnType("varchar(400)");

            modelBuilder.Entity<ProfessionClient>()
                .HasKey(pc => pc.Id);

            modelBuilder.Entity<ProfessionClient>()
                .HasOne(pc => pc.Client)
                .WithMany(pc => pc.ProfessionClients)
                .HasForeignKey(pc => pc.ClientId);


            modelBuilder.Entity<ProfessionClient>()
                .HasOne(pc => pc.Profession)
                .WithMany(pc => pc.ProfessionClients)
                .HasForeignKey(pc => pc.ProfessionId);

            #region Menu 

            modelBuilder.Entity<Menu>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Menu>()
                .HasMany(c => c.SubMenus)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            modelBuilder.Entity<Menu>().Property(m => m.Titulo)
                .HasColumnType("varchar(200)");

            #endregion
        }
    }
}
