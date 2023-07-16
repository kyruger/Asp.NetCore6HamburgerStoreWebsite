using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desserts_Menus_MenuId",
                table: "Desserts");

            migrationBuilder.DropIndex(
                name: "IX_Desserts_MenuId",
                table: "Desserts");

            migrationBuilder.DropColumn(
                name: "DessertId",
                table: "Menus");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sauce",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hamburger",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Frieses",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Drinks",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Desserts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_MenuId",
                table: "Desserts",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desserts_Menus_MenuId",
                table: "Desserts",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desserts_Menus_MenuId",
                table: "Desserts");

            migrationBuilder.DropIndex(
                name: "IX_Desserts_MenuId",
                table: "Desserts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sauce",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DessertId",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hamburger",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Frieses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Desserts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_MenuId",
                table: "Desserts",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Desserts_Menus_MenuId",
                table: "Desserts",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
