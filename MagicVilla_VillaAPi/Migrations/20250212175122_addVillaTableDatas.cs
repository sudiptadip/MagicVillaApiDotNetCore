using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPi.Migrations
{
    /// <inheritdoc />
    public partial class addVillaTableDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9400), new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9993), new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 2, 12, 23, 21, 21, 560, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 21, 21, 561, DateTimeKind.Local), new DateTime(2025, 2, 12, 23, 21, 21, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 21, 21, 561, DateTimeKind.Local).AddTicks(3), new DateTime(2025, 2, 12, 23, 21, 21, 561, DateTimeKind.Local).AddTicks(3) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(4577), new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5208), new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5212), new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5213), new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5215), new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5216) });
        }
    }
}
