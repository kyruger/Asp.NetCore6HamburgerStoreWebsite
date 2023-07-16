using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "70b837b1-e620-4780-afac-b6fc771acac0", new DateTime(2023, 7, 16, 15, 20, 41, 836, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "a35a4f1b-950a-4e43-85d8-07608fa9e5a7", new DateTime(2023, 7, 16, 15, 20, 41, 836, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 837, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 16, 15, 20, 41, 839, DateTimeKind.Local).AddTicks(2888));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
