using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicCollection.Data.Migrations
{
    public partial class addalbumfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Album",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Album",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Album");
        }
    }
}
