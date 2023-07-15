using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "14bd94a9-35df-4e34-8456-660379c0dac9", new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "dbca7cf6-e306-4a9a-b4ad-55b05bc28d91", new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 329, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 332, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 332, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 332, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 332, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 332, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 333, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 333, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 333, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 17, 48, 1, 333, DateTimeKind.Local).AddTicks(702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "Orders");

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Orders",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "5720a584-2a14-4d6f-b8da-8240c1651df3", new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "0f79f40b-72c2-44c0-8d5d-07fd98af0de3", new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8406));
        }
    }
}
