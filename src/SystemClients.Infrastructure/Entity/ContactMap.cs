using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.EntityConfig
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasOne(c => c.Client)
              .WithMany(c => c.Contacts)
              .HasForeignKey(c => c.ClientId)
              .HasPrincipalKey(c => c.ClientId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.Telefone)
                .HasColumnType("varchar(15)");
        }
    }
}
