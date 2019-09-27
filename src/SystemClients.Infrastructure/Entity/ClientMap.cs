using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.EntityConfig
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);

            builder.HasOne(c => c.Adress)
                .WithOne(e => e.Client)
                .HasForeignKey<Adress>(c => c.ClientId);

            builder
                .HasMany(c => c.Contacts)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
