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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Cliente");
        }
    }
}
