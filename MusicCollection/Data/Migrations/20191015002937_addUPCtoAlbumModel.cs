using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicCollection.Data.Migrations
{
    public partial class addUPCtoAlbumModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UPC",
                table: "Album",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UPC",
                table: "Album");
        }
    }
}
