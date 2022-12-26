using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace windowswebgsm.data.Migrations
{
    /// <inheritdoc />
    public partial class ImagePathsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerPath",
                table: "GameServers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "GameServers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SteamName",
                table: "GameServers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerPath",
                table: "GameServers");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "GameServers");

            migrationBuilder.DropColumn(
                name: "SteamName",
                table: "GameServers");
        }
    }
}
