using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addConstraint : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersActionChronology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Who = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8c130bd5-3e5b-4012-a140-5927a3a00a9a", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ddd0d8d6-9cb5-480d-8f37-5e825011376c", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "87845f59-25f0-4500-9537-820b4091ff07", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "dd603127-1af2-466c-9109-de6709e50e59", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d93d8b8d-e783-4cb0-ba3b-31fae8744e08", "AQAAAAEAACcQAAAAENbtNZGm0AHo3zeukn6kByWzjtF3gkS6GHNX/yQOHS78erOMDOlHAfcylN45fkGX9A==", "29c3e806-2f8f-49f3-af98-6f5e3a828da5", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersActionChronology_OrderId",
                table: "OrdersActionChronology",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersActionChronology_Who",
                table: "OrdersActionChronology",
                column: "Who");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersActionChronology");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "272b64e1-d7cb-46cd-bd2b-56ec24e1fcd6", new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8327fd42-0d9f-4d1f-85f8-3dad755be226", new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4e89b65a-8e88-4217-957a-53f3c7c3af86", new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b6edbd8e-1d6a-4419-b491-51b8c2ee77a3", new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "78ebc31a-a1b6-4097-b060-b0595153006e", "AQAAAAEAACcQAAAAEPDAFpO4zIPM1UwTHffnm11tfKDps0qprlanBWi8JE+QgIJJBKgUWOaCzzA7P+BU8g==", "52647def-40ec-4382-a793-11616b5004bf", new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 38, 41, 488, DateTimeKind.Local).AddTicks(5007));
        }
    }
}
