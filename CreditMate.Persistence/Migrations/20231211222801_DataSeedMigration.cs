using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CreditMate.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Celular", "Cpf", "CreatedAt", "IsActive", "Nome", "Uf", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a1f2565e-d7e6-4170-9b35-7d1228ea55f1"), "(11)951136376", "38586555894", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8830), true, "Casey Adesola Fernandes", "SP", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8844) },
                    { new Guid("a26635ef-b924-4a97-873e-26c2801d323a"), "(27)989000360", "53119013064", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8886), true, "Lucas Amorim", "SP", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8886) },
                    { new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"), "(45)996176307", "53546002512", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8903), true, "Douglas Eduardo", "SP", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8904) }
                });

            migrationBuilder.InsertData(
                table: "Financiamento",
                columns: new[] { "Id", "ClienteId", "Cpf", "CreatedAt", "IsActive", "TipoFinanciamento", "UltimoVencimento", "UpdatedAt", "ValorTotal" },
                values: new object[,]
                {
                    { new Guid("aa77cc25-111c-4011-9d27-bd630a32753f"), null, "53546002512", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8971), true, 3, new DateTime(2024, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8972), 200000m },
                    { new Guid("abc3a4f6-ea22-4523-9915-f13a5f5e6253"), null, "53119013064", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8955), true, 1, new DateTime(2025, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8955), 800000m },
                    { new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"), null, "38586555894", new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8935), true, 0, new DateTime(2024, 6, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8936), 50000m }
                });

            migrationBuilder.InsertData(
                table: "Parcela",
                columns: new[] { "Id", "CreatedAt", "DataPagamento", "DataVencimento", "FinanciamentoId", "IsActive", "NumeroParcela", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { new Guid("7eb2d084-8fad-4078-856b-8f60658d860e"), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9041), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9039), new Guid("aa77cc25-111c-4011-9d27-bd630a32753f"), true, 1, new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9042), 1666m },
                    { new Guid("cbfc78b8-8651-4c3a-b1f3-495d35372526"), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(8992), new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"), true, 1, new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9003), 8333m },
                    { new Guid("f96444c8-e822-43eb-ae1d-6531c2374ae2"), new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9021), new Guid("abc3a4f6-ea22-4523-9915-f13a5f5e6253"), true, 1, new DateTime(2023, 12, 11, 19, 28, 1, 283, DateTimeKind.Local).AddTicks(9024), 3333m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a1f2565e-d7e6-4170-9b35-7d1228ea55f1"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a26635ef-b924-4a97-873e-26c2801d323a"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"));

            migrationBuilder.DeleteData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("7eb2d084-8fad-4078-856b-8f60658d860e"));

            migrationBuilder.DeleteData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("cbfc78b8-8651-4c3a-b1f3-495d35372526"));

            migrationBuilder.DeleteData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("f96444c8-e822-43eb-ae1d-6531c2374ae2"));

            migrationBuilder.DeleteData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("aa77cc25-111c-4011-9d27-bd630a32753f"));

            migrationBuilder.DeleteData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("abc3a4f6-ea22-4523-9915-f13a5f5e6253"));

            migrationBuilder.DeleteData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"));
        }
    }
}
