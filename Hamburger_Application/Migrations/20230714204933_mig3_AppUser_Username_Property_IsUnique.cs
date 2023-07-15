using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig3_AppUser_Username_Property_IsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "51aef843-1919-4cd2-aac9-322cd335f970", new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "947ac3c7-0a51-42a3-b177-79196c76ef37", new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 814, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 815, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 14, 23, 49, 30, 817, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers");

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
    }
}
