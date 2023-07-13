using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "210f5c64-6f42-43f0-8e4c-46e4dd5c27f8", new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "304bc817-ed7f-4e3d-ab83-df2cf5e4d003", new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 472, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 49, 40, 474, DateTimeKind.Local).AddTicks(8828));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "38a02e6b-d48d-449e-ac9f-47b28504fdfe", new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "107c412c-0e00-44c9-a498-58fefd62933c", new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 885, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 13, 16, 47, 34, 887, DateTimeKind.Local).AddTicks(8280));
        }
    }
}
