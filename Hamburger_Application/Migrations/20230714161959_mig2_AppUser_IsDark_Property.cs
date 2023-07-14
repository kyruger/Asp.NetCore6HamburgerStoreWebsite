using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig2_AppUser_IsDark_Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDark",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "3770ba9d-a204-4758-892d-f882ecf84773", new DateTime(2023, 7, 14, 19, 19, 57, 128, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "8d463fd5-65f2-469f-b23c-f27eef8a6a9c", new DateTime(2023, 7, 14, 19, 19, 57, 128, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 129, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 19, 19, 57, 131, DateTimeKind.Local).AddTicks(7263));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDark",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "5d2cdd39-0277-41b1-b5e2-708610b757dd", new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "9efb3c33-a4b9-4699-bc95-83b5f7c5bcde", new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 362, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 363, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 1, 56, 59, 366, DateTimeKind.Local).AddTicks(4703));
        }
    }
}
