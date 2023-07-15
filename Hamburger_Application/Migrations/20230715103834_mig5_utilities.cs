using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig5_utilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "47abaf8c-e9b9-4267-839b-70d4124d8f78", new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "df74dffe-b40e-4c23-b95d-f330c7bbaf6d", new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 665, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 666, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 13, 38, 30, 668, DateTimeKind.Local).AddTicks(9359));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
