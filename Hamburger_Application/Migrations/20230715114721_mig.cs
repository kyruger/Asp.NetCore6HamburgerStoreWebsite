using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDark = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DessertId = table.Column<int>(type: "int", nullable: true),
                    DrinkId = table.Column<int>(type: "int", nullable: true),
                    FriesId = table.Column<int>(type: "int", nullable: true),
                    HamburgerId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Desserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desserts_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Desserts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Drinks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Frieses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frieses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frieses_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Frieses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hamburger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hamburger_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Hamburger_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sauce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sauce_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sauce_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "5720a584-2a14-4d6f-b8da-8240c1651df3", new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(933), "Admin", "ADMIN" },
                    { 2, "0f79f40b-72c2-44c0-8d5d-07fd98af0de3", new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(948), "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3761), null, "Brownie", null, null, 1, 50m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3770), null, "Milkshake", null, null, 1, 40m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3827), null, "Cheesecake", null, null, 1, 60m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3828), null, "Ice Cream", null, null, 1, 30m },
                    { 5, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(3829), null, "Puding", null, null, 1, 40m }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4310), null, "Coke", null, null, 1, 40m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4313), null, "Ayran", null, null, 1, 25m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4314), null, "Coke Zero", null, null, 1, 45m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4315), null, "Cold Tea", null, null, 1, 35m },
                    { 5, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4316), null, "Mineral Water", null, null, 1, 15m }
                });

            migrationBuilder.InsertData(
                table: "Frieses",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4814), null, "Potato", null, null, 1, 20m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4816), null, "Onion Ring", null, null, 1, 22m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4818), null, "Nugget", null, null, 1, 25m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(4819), null, "Chicken Tenders", null, null, 1, 25m }
                });

            migrationBuilder.InsertData(
                table: "Hamburger",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5199), null, "Whopper", null, null, 1, 120m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5201), null, "Texas SmokeHouse", null, null, 1, 140m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5203), null, "Fish Royale", null, null, 1, 110m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5204), null, "Big King", null, null, 1, 150m },
                    { 5, new DateTime(2023, 7, 15, 14, 47, 19, 213, DateTimeKind.Local).AddTicks(5205), null, "Chicken Royale", null, null, 1, 95m }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreationTime", "DessertId", "DrinkId", "FriesId", "HamburgerId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7330), null, 1, 1, 1, "Whopper Menu", null, null, 1, 150m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7355), null, 1, 1, 2, "Texas SmokeHouse Menu", null, null, 1, 170m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7357), null, 1, 1, 3, "Fish Royale Menu", null, null, 1, 140m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7359), null, 1, 1, 4, "Big King Menu", null, null, 1, 150m },
                    { 5, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(7361), null, 1, 1, 5, "Chicken Royale Menu", null, null, 1, 120m }
                });

            migrationBuilder.InsertData(
                table: "Sauce",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Piece", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8400), null, "Ranch", null, null, 1, 15m },
                    { 2, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8403), null, "Ketchup", null, null, 1, 10m },
                    { 3, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8404), null, "Mayonnaise", null, null, 1, 10m },
                    { 4, new DateTime(2023, 7, 15, 14, 47, 19, 215, DateTimeKind.Local).AddTicks(8406), null, "Barbeque", null, null, 1, 15m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_MenuId",
                table: "Desserts",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_OrderId",
                table: "Desserts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MenuId",
                table: "Drinks",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Frieses_MenuId",
                table: "Frieses",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Frieses_OrderId",
                table: "Frieses",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_MenuId",
                table: "Hamburger",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_OrderId",
                table: "Hamburger",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderId",
                table: "Menus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sauce_MenuId",
                table: "Sauce",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Sauce_OrderId",
                table: "Sauce",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Desserts");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Frieses");

            migrationBuilder.DropTable(
                name: "Hamburger");

            migrationBuilder.DropTable(
                name: "Sauce");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
