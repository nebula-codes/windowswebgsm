using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace windowswebgsm.data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "GameServers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "GameServers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
