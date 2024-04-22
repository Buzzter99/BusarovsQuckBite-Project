using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuickBite.Infrastructure.Migrations
{
    public partial class initialCreateChangeNameSpaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RelativePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Img", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(40)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(40)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(40)", nullable: false),
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,5)", precision: 18, scale: 5, nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Img_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Img",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersActionChronology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NewStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersActionChronology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersActionChronology_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersActionChronology_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => new { x.CartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersProducts",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    QtyOrdered = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProducts", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TransactionDateAndTime" },
                values: new object[,]
                {
                    { "22ccb117-1c50-47a5-bc43-1d9a84879e10", "ed920c5d-bbe5-4ee7-a354-84794414f2f4", "Delivery Driver", "DELIVERY DRIVER", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(6735) },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "e8559386-a7fc-4f05-a497-7488b5063a1c", "Admin", "ADMIN", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(6719) },
                    { "a1a8637e-6e83-4ee9-adef-09cd724473a7", "801f79a6-6a9d-4676-83c5-3293f6659a8e", "Cooking Staff", "COOKING STAFF", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(6740) },
                    { "fa175b24-e5a7-41ab-8237-94734f2b5408", "375ffe0e-d8ac-4322-97b0-b6175ee93479", "Customer", "CUSTOMER", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(6729) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TransactionDateAndTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "8f501ce9-4b49-4ec6-b19f-03e1493955e4", "brandabg1@gmail.com", true, "", true, "", false, null, "BRANDABG1@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJXBsI3LPeeWP8pewaY//qSYkkmDWWFUERootToqXqTI6Wd17phmxiBmXJNLL/7C0A==", "0896722926", true, "c38483d7-8ab6-45ef-8d70-e2e8b398e353", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(6552), false, "Admin" });

            migrationBuilder.InsertData(
                table: "Img",
                columns: new[] { "Id", "FullPath", "Name", "RelativePath" },
                values: new object[,]
                {
                    { 1, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\download.jpg", "download.jpg", "~\\Images\\" },
                    { 2, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\tuborg.jpg", "tuborg.jpg", "~\\Images\\" },
                    { 3, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\hamburger-baked-in-oven.jpg", "hamburger-baked-in-oven.jpg", "~\\Images\\" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name", "TransactionDateAndTime", "Who" },
                values: new object[,]
                {
                    { 1, false, "Snacks", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7597), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 2, false, "Burgers", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7607), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 3, false, "Drinks", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7610), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 4, false, "Pizzas", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7612), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 5, false, "Pasta", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7613), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 6, false, "Sandwiches", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7616), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 7, false, "Desserts", new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(7617), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 1, 4, "Pizza", 1, false, "Pepperoni Pizza", 15.00m, 10, new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(8533), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 2, 3, "Beer", 2, false, "Tuborg Beer", 5.00m, 50, new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(8544), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 3, 2, "Burger", 3, false, "Hamburger", 8.50m, 15, new DateTime(2024, 4, 22, 3, 22, 56, 166, DateTimeKind.Local).AddTicks(8546), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Who",
                table: "Addresses",
                column: "Who");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Who",
                table: "Carts",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Who",
                table: "Categories",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Who",
                table: "Orders",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersActionChronology_OrderId",
                table: "OrdersActionChronology",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersActionChronology_Who",
                table: "OrdersActionChronology",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ProductId",
                table: "OrdersProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Who",
                table: "Products",
                column: "Who");
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
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "OrdersActionChronology");

            migrationBuilder.DropTable(
                name: "OrdersProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Img");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
