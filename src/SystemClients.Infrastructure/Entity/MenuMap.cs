using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder
               .HasKey(m => m.Id);

            builder
                .HasMany(c => c.SubMenus)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            builder.Property(m => m.Titulo)
                .HasColumnType("varchar(200)");
        }
    }
}
