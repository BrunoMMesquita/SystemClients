using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;
using SystemClients.Infrastructure.EntityConfig;

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

            modelBuilder.ApplyConfiguration(new ClientMap());

            modelBuilder.ApplyConfiguration(new ContactMap());

            modelBuilder.ApplyConfiguration(new ProfessionMap());

            modelBuilder.ApplyConfiguration(new AdressMap());

            modelBuilder.ApplyConfiguration(new MenuMap());

            modelBuilder.ApplyConfiguration(new ProfessionMap());
        
        }
    }
}
