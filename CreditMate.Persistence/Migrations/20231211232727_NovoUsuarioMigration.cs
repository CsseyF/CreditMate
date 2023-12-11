using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreditMate.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NovoUsuarioMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a1f2565e-d7e6-4170-9b35-7d1228ea55f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a26635ef-b924-4a97-873e-26c2801d323a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Celular", "Cpf", "CreatedAt", "IsActive", "Nome", "Uf", "UpdatedAt" },
                values: new object[] { new Guid("f312357b-6f1a-494d-9425-6cbc3f4ad9a7"), "(21)987646298", "27310180038", new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3062), true, "Guilherme Barros", "RJ", new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("aa77cc25-111c-4011-9d27-bd630a32753f"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3136), new DateTime(2024, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("abc3a4f6-ea22-4523-9915-f13a5f5e6253"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3119), new DateTime(2025, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3117), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 6, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("7eb2d084-8fad-4078-856b-8f60658d860e"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 12, 31, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("cbfc78b8-8651-4c3a-b1f3-495d35372526"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3171), new DateTime(2023, 12, 31, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3153), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("f96444c8-e822-43eb-ae1d-6531c2374ae2"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 12, 31, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 12, 11, 20, 27, 27, 125, DateTimeKind.Local).AddTicks(3193) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("f312357b-6f1a-494d-9425-6cbc3f4ad9a7"));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a1f2565e-d7e6-4170-9b35-7d1228ea55f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("a26635ef-b924-4a97-873e-26c2801d323a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(928), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("aa77cc25-111c-4011-9d27-bd630a32753f"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(999), new DateTime(2024, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(998), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("abc3a4f6-ea22-4523-9915-f13a5f5e6253"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(983), new DateTime(2025, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(978), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Financiamento",
                keyColumn: "Id",
                keyValue: new Guid("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                columns: new[] { "CreatedAt", "UltimoVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 6, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(948), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("7eb2d084-8fad-4078-856b-8f60658d860e"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1068), new DateTime(2023, 12, 31, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1067), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("cbfc78b8-8651-4c3a-b1f3-495d35372526"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 12, 31, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Parcela",
                keyColumn: "Id",
                keyValue: new Guid("f96444c8-e822-43eb-ae1d-6531c2374ae2"),
                columns: new[] { "CreatedAt", "DataVencimento", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 12, 31, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 12, 11, 19, 48, 47, 528, DateTimeKind.Local).AddTicks(1050) });
        }
    }
}
