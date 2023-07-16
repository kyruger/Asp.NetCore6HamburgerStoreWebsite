using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "12541735-fa5b-4e98-b700-ae62ec873a70", new DateTime(2023, 7, 16, 14, 28, 24, 844, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "83b23caa-1ba6-458a-8430-865cf1e594a5", new DateTime(2023, 7, 16, 14, 28, 24, 844, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 845, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 14, 28, 24, 847, DateTimeKind.Local).AddTicks(2766));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "5ee32bc0-ea77-4538-b7ba-05a7caf56bbb", new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "a56735a4-c1c5-4070-a576-4d0ac4c295e1", new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 356, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 11, 44, 48, 358, DateTimeKind.Local).AddTicks(5380));
        }
    }
}
