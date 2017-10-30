﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Troostwik.Context;

namespace Troostwik.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Troostwik.Domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<string>("Name");

                    b.Property<int?>("SaleId");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Troostwik.Domain.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInformation");

                    b.Property<string>("Name");

                    b.Property<double>("Sum");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Troostwik.Domain.Item", b =>
                {
                    b.HasOne("Troostwik.Domain.Sale", "Sale")
                        .WithMany("Items")
                        .HasForeignKey("SaleId");
                });
#pragma warning restore 612, 618
        }
    }
}
