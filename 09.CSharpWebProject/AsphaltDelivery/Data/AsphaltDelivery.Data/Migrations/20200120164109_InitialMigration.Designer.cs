﻿// <auto-generated />
using System;
using AsphaltDelivery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsphaltDelivery.Data.Migrations
{
    [DbContext(typeof(AsphaltDeliveryDbContext))]
    [Migration("20200120164109_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsphaltDelivery.Data.Models.AsphaltBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AsphaltBases");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.AsphaltMixture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("AsphaltMixtures");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsphaltBaseId")
                        .HasColumnType("int");

                    b.Property<int>("AsphaltMixtureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<int>("RoadObjectId")
                        .HasColumnType("int");

                    b.Property<double>("TransportDistance")
                        .HasColumnType("float");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AsphaltBaseId");

                    b.HasIndex("AsphaltMixtureId");

                    b.HasIndex("DriverId");

                    b.HasIndex("FirmId");

                    b.HasIndex("RoadObjectId");

                    b.HasIndex("TruckId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.RoadObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("RoadObjects");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.TruckDriver", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("DriverId", "TruckId");

                    b.HasIndex("TruckId");

                    b.ToTable("TruckDrivers");
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Course", b =>
                {
                    b.HasOne("AsphaltDelivery.Data.Models.AsphaltBase", "AsphaltBase")
                        .WithMany("Courses")
                        .HasForeignKey("AsphaltBaseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.AsphaltMixture", "AsphaltMixture")
                        .WithMany("Courses")
                        .HasForeignKey("AsphaltMixtureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.Driver", "Driver")
                        .WithMany("Courses")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.Firm", "Firm")
                        .WithMany("Courses")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.RoadObject", "RoadObject")
                        .WithMany("Courses")
                        .HasForeignKey("RoadObjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.Truck", "Truck")
                        .WithMany("Courses")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Driver", b =>
                {
                    b.HasOne("AsphaltDelivery.Data.Models.Firm", "Firm")
                        .WithMany("Drivers")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.Truck", b =>
                {
                    b.HasOne("AsphaltDelivery.Data.Models.Firm", "Firm")
                        .WithMany("Trucks")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("AsphaltDelivery.Data.Models.TruckDriver", b =>
                {
                    b.HasOne("AsphaltDelivery.Data.Models.Driver", "Driver")
                        .WithMany("DriverTrucks")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AsphaltDelivery.Data.Models.Truck", "Truck")
                        .WithMany("TruckDrivers")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
