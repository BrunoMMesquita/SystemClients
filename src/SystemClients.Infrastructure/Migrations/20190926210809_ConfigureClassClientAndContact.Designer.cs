﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SystemClients.Infrastructure.Data;

namespace SystemClients.Infrastructure.Migrations
{
    [DbContext(typeof(ClientContext))]
    [Migration("20190926210809_ConfigureClassClientAndContact")]
    partial class ConfigureClassClientAndContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SystemClients.ApplicationCore.Entity.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar=(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar=(11)");

                    b.HasKey("ClientId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SystemClients.ApplicationCore.Entity.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar=(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar=(200)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar=(15)");

                    b.HasKey("ContactId");

                    b.HasIndex("ClientId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SystemClients.ApplicationCore.Entity.Contact", b =>
                {
                    b.HasOne("SystemClients.ApplicationCore.Entity.Client", "Client")
                        .WithMany("Contacts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
