using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.EntityConfig
{
    public class AdressMap : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasKey(a => a.AdressId);
 
            builder.Property(c => c.Bairro)
              .HasColumnType("varchar(200)")
              .IsRequired();

            builder.Property(c => c.Cep)
              .HasColumnType("varchar(15)")
              .IsRequired();

            builder.Property(c => c.Logradouro)
              .HasColumnType("varchar(200)")
              .IsRequired();

            builder.Property(c => c.Referencia)
           .HasColumnType("varchar(400)");
        }
    }
}
