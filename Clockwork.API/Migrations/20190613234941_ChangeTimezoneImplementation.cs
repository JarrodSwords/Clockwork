using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clockwork.API.Migrations
{
    public partial class ChangeTimezoneImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerTimeQueries");

            migrationBuilder.AddColumn<string>(
                name: "TimezoneId",
                table: "CurrentTimeQueries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimezoneId",
                table: "CurrentTimeQueries");

            migrationBuilder.CreateTable(
                name: "ServerTimeQueries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientIp = table.Column<string>(nullable: true),
                    RequestTime = table.Column<DateTime>(nullable: false),
                    TimezoneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerTimeQueries", x => x.Id);
                });
        }
    }
}
