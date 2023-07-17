using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class migi : Migration
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
                    IsDark = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Desserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desserts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DrinkId = table.Column<int>(type: "int", nullable: true),
                    FriesId = table.Column<int>(type: "int", nullable: true),
                    HamburgerId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
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
                name: "Sauce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sauce_Orders_OrderId",
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
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
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
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
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
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "335de442-1cdd-428d-b9b3-78e7ee47666d", new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(1545), "Admin", "ADMIN" },
                    { 2, "f2755e47-daa9-4abc-b9d6-e1dcd875ca0c", new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(1558), "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "CreationTime", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(4739), "Brownie", null, null, 50m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(4747), "Milkshake", null, null, 40m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(4748), "Cheesecake", null, null, 60m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(4749), "Ice Cream", null, null, 30m },
                    { 5, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(4750), "Puding", null, null, 40m }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(5948), null, "Coke", null, null, 40m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(5952), null, "Ayran", null, null, 25m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(5953), null, "Coke Zero", null, null, 45m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(5954), null, "Cold Tea", null, null, 35m },
                    { 5, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(5955), null, "Mineral Water", null, null, 15m }
                });

            migrationBuilder.InsertData(
                table: "Frieses",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(7068), null, "Potato", null, null, 20m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(7071), null, "Onion Ring", null, null, 22m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(7073), null, "Nugget", null, null, 25m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(7074), null, "Chicken Tenders", null, null, 25m }
                });

            migrationBuilder.InsertData(
                table: "Hamburger",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(8537), null, "Whopper", null, null, 120m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(8540), null, "Texas SmokeHouse", null, null, 140m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(8541), null, "Fish Royale", null, null, 110m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(8542), null, "Big King", null, null, 150m },
                    { 5, new DateTime(2023, 7, 17, 11, 8, 52, 458, DateTimeKind.Local).AddTicks(8543), null, "Chicken Royale", null, null, 95m }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreationTime", "DrinkId", "FriesId", "HamburgerId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(1922), 1, 1, 1, "Whopper Menu", null, null, 150m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(1933), 1, 1, 2, "Texas SmokeHouse Menu", null, null, 170m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(1935), 1, 1, 3, "Fish Royale Menu", null, null, 140m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(1936), 1, 1, 4, "Big King Menu", null, null, 150m },
                    { 5, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(1938), 1, 1, 5, "Chicken Royale Menu", null, null, 120m }
                });

            migrationBuilder.InsertData(
                table: "Sauce",
                columns: new[] { "Id", "CreationTime", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(3603), "Ranch", null, null, 15m },
                    { 2, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(3607), "Ketchup", null, null, 10m },
                    { 3, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(3608), "Mayonnaise", null, null, 10m },
                    { 4, new DateTime(2023, 7, 17, 11, 8, 52, 460, DateTimeKind.Local).AddTicks(3609), "Barbeque", null, null, 15m }
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
                name: "IX_Desserts_Name",
                table: "Desserts",
                column: "Name",
                unique: true);

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
                name: "IX_Drinks_Name",
                table: "Drinks",
                column: "Name",
                unique: true);

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
                name: "IX_Frieses_Name",
                table: "Frieses",
                column: "Name",
                unique: true);

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
                name: "IX_Hamburger_Name",
                table: "Hamburger",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_OrderId",
                table: "Hamburger",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Name",
                table: "Menus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderId",
                table: "Menus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sauce_Name",
                table: "Sauce",
                column: "Name",
                unique: true);

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
