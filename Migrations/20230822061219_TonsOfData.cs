using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication.Migrations
{
    /// <inheritdoc />
    public partial class TonsOfData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DayOfBirthday", "Fortune", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "Samuel L. Jackson" },
                    { 3, new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000m, "Robert Downey Jr." }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "InTheaters", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, false, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: No Way Home" },
                    { 4, false, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: Across the Spider-Verse (Part One)" },
                    { 5, false, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers Endgame" }
                });

            migrationBuilder.InsertData(
                table: "GenreMovie",
                columns: new[] { "GenresId", "MoviesId" },
                values: new object[,]
                {
                    { 5, 3 },
                    { 5, 5 },
                    { 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId", "Character", "Order" },
                values: new object[,]
                {
                    { 2, 3, "Nick Fury", 1 },
                    { 2, 5, "Nick Fury", 2 },
                    { 3, 5, "Iron Man", 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieComments",
                columns: new[] { "Id", "Content", "MovieId", "Recommend" },
                values: new object[,]
                {
                    { 4, "Very good!!!", 5, true },
                    { 5, "I love it!", 5, true },
                    { 6, "They shouldn't have done that", 3, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresId", "MoviesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresId", "MoviesId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresId", "MoviesId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
