using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Sauce",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Hamburger",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Frieses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Drinks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Desserts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "34e17149-f3f6-41a0-8b55-e6d8aa4a1920", new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "22b7eca1-8364-45ae-85e3-19d8084a6b3e", new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Frieses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Hamburger",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 915, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 7, 15, 18, 27, 34, 917, DateTimeKind.Local).AddTicks(3595));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Sauce",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Hamburger",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Frieses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Drinks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Piece",
                table: "Desserts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
