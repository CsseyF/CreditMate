using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreditMate.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ParcelaCorrectionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorVencimento",
                table: "Parcela");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Parcela",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Parcela");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValorVencimento",
                table: "Parcela",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
