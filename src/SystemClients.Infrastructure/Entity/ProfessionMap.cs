using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.EntityConfig
{
    public class ProfessionMap : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.Property(c => c.Name)
              .HasColumnType("varchar(400)")
              .IsRequired();

            builder.Property(c => c.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(c => c.Description)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
