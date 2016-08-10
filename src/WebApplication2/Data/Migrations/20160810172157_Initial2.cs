using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "description",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "name",
                table: "movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "movies",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "movies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "movies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "movies",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "movies",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "Movie",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "movies");
        }
    }
}
