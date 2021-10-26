using Microsoft.EntityFrameworkCore.Migrations;

namespace windowswebgsm.Data.Migrations
{
    public partial class CreateServerDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SteamID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    QueryPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Players = table.Column<int>(type: "int", nullable: false),
                    MaxPlayers = table.Column<int>(type: "int", nullable: false),
                    Uptime = table.Column<int>(type: "int", nullable: false),
                    FormattedUptime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoRestart = table.Column<bool>(type: "bit", nullable: false),
                    AutoStart = table.Column<bool>(type: "bit", nullable: false),
                    AutoUpdate = table.Column<bool>(type: "bit", nullable: false),
                    UpdateOnStart = table.Column<bool>(type: "bit", nullable: false),
                    BackupOnStart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
