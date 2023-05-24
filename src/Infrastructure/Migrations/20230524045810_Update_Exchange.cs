using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_Exchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaxIncomes",
                keyColumn: "Id",
                keyValue: new Guid("c0b17a9e-ee6f-4fe0-8e6f-33d5c63640c8"),
                column: "Muc_chiu_thue",
                value: 32000000.0);

            migrationBuilder.UpdateData(
                table: "TaxIncomes",
                keyColumn: "Id",
                keyValue: new Guid("f0f3e78c-67c9-4e5e-a9fc-c8d2e7c1e5f5"),
                column: "Muc_chiu_thue",
                value: 52000000.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaxIncomes",
                keyColumn: "Id",
                keyValue: new Guid("c0b17a9e-ee6f-4fe0-8e6f-33d5c63640c8"),
                column: "Muc_chiu_thue",
                value: 3200000.0);

            migrationBuilder.UpdateData(
                table: "TaxIncomes",
                keyColumn: "Id",
                keyValue: new Guid("f0f3e78c-67c9-4e5e-a9fc-c8d2e7c1e5f5"),
                column: "Muc_chiu_thue",
                value: 5200000.0);
        }
    }
}
