﻿// <auto-generated />
using GeoProfs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Geoprofs_v2.Models.Werknemer", b =>
                {
                    b.Property<int>("werknemer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.HasKey("werknemer_id");

                    b.ToTable("Werknemers");
                });
#pragma warning restore 612, 618
        }
    }
}
