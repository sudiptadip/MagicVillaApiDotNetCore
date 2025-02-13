using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPi.Migrations
{
    /// <inheritdoc />
    public partial class addVillaTableDatassw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedData", "UpdatedData" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
