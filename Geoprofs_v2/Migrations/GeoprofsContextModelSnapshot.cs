﻿// <auto-generated />
using System;
using GeoProfs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Geoprofs_v2.Migrations
{
    [DbContext(typeof(GeoprofsContext))]
    partial class GeoprofsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Geoprofs_v2.Models.VerlofAanvraag", b =>
                {
                    b.Property<int>("verlof_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("verlofReden")
                        .HasColumnType("int");

                    b.Property<int>("verlofStatus")
                        .HasColumnType("int");

                    b.Property<int>("werknemer_id")
                        .HasColumnType("int");

                    b.HasKey("verlof_id");

                    b.ToTable("VerlofAanvraag");
                });

            modelBuilder.Entity("Geoprofs_v2.Models.Werknemer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Werknemers");
                });
#pragma warning restore 612, 618
        }
    }
}
