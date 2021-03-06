﻿// <auto-generated />
using EndangeredAnimalsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EndangeredAnimalsAPI.Migrations
{
    [DbContext(typeof(EndangeredAnimalsAPIContext))]
    partial class EndangeredAnimalsAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EndangeredAnimalsAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("CommonName");

                    b.Property<string>("Conservation");

                    b.Property<string>("Countries");

                    b.Property<string>("Family");

                    b.Property<string>("GeographicRange");

                    b.Property<string>("Habitat");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Population");

                    b.Property<string>("Population_Trend");

                    b.Property<string>("SciName");

                    b.Property<int>("TaxonId");

                    b.Property<string>("Threats");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
