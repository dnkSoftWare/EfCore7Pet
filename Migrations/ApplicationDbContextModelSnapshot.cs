﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication;

#nullable disable

namespace WebApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("integer");

                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");

                    b.HasData(
                        new
                        {
                            GenresId = 5,
                            MoviesId = 5
                        },
                        new
                        {
                            GenresId = 5,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 6,
                            MoviesId = 4
                        });
                });

            modelBuilder.Entity("WebApplication.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DayOfBirthday")
                        .HasColumnType("date");

                    b.Property<decimal>("Fortune")
                        .HasPrecision(18, 2)
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DayOfBirthday = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 15000m,
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            DayOfBirthday = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 18000m,
                            Name = "Robert Downey Jr."
                        });
                });

            modelBuilder.Entity("WebApplication.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<bool>("Recommend")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieComments");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Content = "Very good!!!",
                            MovieId = 5,
                            Recommend = true
                        },
                        new
                        {
                            Id = 5,
                            Content = "I love it!",
                            MovieId = 5,
                            Recommend = true
                        },
                        new
                        {
                            Id = 6,
                            Content = "They shouldn't have done that",
                            MovieId = 3,
                            Recommend = false
                        });
                });

            modelBuilder.Entity("WebApplication.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Animation"
                        });
                });

            modelBuilder.Entity("WebApplication.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("InTheaters")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avengers Endgame"
                        },
                        new
                        {
                            Id = 3,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: No Way Home"
                        },
                        new
                        {
                            Id = 4,
                            InTheaters = false,
                            ReleaseDate = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: Across the Spider-Verse (Part One)"
                        });
                });

            modelBuilder.Entity("WebApplication.Entities.MovieActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            MovieId = 3,
                            Character = "Nick Fury",
                            Order = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 5,
                            Character = "Nick Fury",
                            Order = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 5,
                            Character = "Iron Man",
                            Order = 1
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("WebApplication.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication.Entities.Comment", b =>
                {
                    b.HasOne("WebApplication.Entities.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("WebApplication.Entities.MovieActor", b =>
                {
                    b.HasOne("WebApplication.Entities.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication.Entities.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("WebApplication.Entities.Actor", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("WebApplication.Entities.Movie", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("MovieActors");
                });
#pragma warning restore 612, 618
        }
    }
}
