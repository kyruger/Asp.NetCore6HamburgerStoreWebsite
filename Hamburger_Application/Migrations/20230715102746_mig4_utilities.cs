using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig4_utilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "a72e83cf-0ea5-4a70-8b85-4f86d4ea42f0", new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "68d46799-bb2e-432a-8a65-cf079a1a603e", new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 280, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 27, 44, 283, DateTimeKind.Local).AddTicks(2122));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "7d5d2c60-f1db-45a1-b8c4-992333b4c974", new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "33d3c529-93ee-4511-afa0-3f2a958441dc", new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 666, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 22, 36, 670, DateTimeKind.Local).AddTicks(3644));
        }
    }
}
