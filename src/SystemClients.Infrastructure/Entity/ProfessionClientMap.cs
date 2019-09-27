using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.Entity
{
    public class ProfessionClientMap : IEntityTypeConfiguration<ProfessionClient>
    {
        public void Configure(EntityTypeBuilder<ProfessionClient> builder)
        {
            builder
            .HasKey(pc => pc.Id);

            builder
                .HasOne(pc => pc.Client)
                .WithMany(pc => pc.ProfessionClients)
                .HasForeignKey(pc => pc.ClientId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .HasOne(pc => pc.Profession)
                .WithMany(pc => pc.ProfessionClients)
                .HasForeignKey(pc => pc.ProfessionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
