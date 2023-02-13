﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_jn375.Models;

namespace Mission6_jn375.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_jn375.Models.ModelClass", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("MovieInputs");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Kevin Reynolds",
                            Edited = true,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Count of Monte Cristo",
                            Year = 2002
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Animated",
                            Director = "Adrian Molina",
                            Edited = true,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Coco",
                            Year = 2017
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Animated",
                            Director = "Kelly Asbury",
                            Edited = true,
                            LentTo = "",
                            Notes = "",
                            Rating = "G",
                            Title = "Spirit",
                            Year = 2002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
