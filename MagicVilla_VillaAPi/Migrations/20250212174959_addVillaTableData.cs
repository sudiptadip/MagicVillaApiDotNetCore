using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPi.Migrations
{
    /// <inheritdoc />
    public partial class addVillaTableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedData", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedData" },
                values: new object[,]
                {
                    { 1, "Pool, Spa, Private Beach", new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(4577), "Luxurious villa with ocean view", "https://example.com/royal-villa.jpg", "Royal Villa", 4, 500.0, 2000, new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(4827) },
                    { 2, "Fireplace, Hiking Trails, Hot Tub", new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5208), "Cozy villa in the mountains", "https://example.com/mountain-retreat.jpg", "Mountain Retreat", 6, 350.0, 1500, new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5210) },
                    { 3, "Beach Access, BBQ, Surfing Gear", new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5212), "A villa near the beautiful beach", "https://example.com/seaside-escape.jpg", "Seaside Escape", 5, 450.0, 1800, new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5212) },
                    { 4, "Hiking, Wildlife Watching, Fireplace", new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5213), "Peaceful retreat surrounded by trees", "https://example.com/forest-haven.jpg", "Forest Haven", 4, 300.0, 1300, new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5214) },
                    { 5, "Infinity Pool, Camel Rides, Private Chef", new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5215), "A luxurious stay in the heart of the desert", "https://example.com/desert-oasis.jpg", "Desert Oasis", 3, 400.0, 1700, new DateTime(2025, 2, 12, 23, 19, 59, 388, DateTimeKind.Local).AddTicks(5216) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
