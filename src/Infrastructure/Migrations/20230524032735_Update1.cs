using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "OvertimeLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "OvertimeLogs",
                keyColumn: "Id",
                keyValue: new Guid("36cb5368-1b04-4b23-bdc0-2949ae3568d7"),
                column: "Status",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "OvertimeLogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "OvertimeLogs",
                keyColumn: "Id",
                keyValue: new Guid("36cb5368-1b04-4b23-bdc0-2949ae3568d7"),
                column: "Status",
                value: false);
        }
    }
}
