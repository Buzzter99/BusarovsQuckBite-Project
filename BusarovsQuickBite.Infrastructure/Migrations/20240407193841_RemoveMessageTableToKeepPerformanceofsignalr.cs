using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class RemoveMessageTableToKeepPerformanceofsignalr : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromUser = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ToUser = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_FromUser",
                        column: x => x.FromUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ToUser",
                        column: x => x.ToUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ba08325d-1071-407b-afb9-f8074c29130f", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "032b18a2-001c-4545-a610-8d9c0d3fdd45", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "62ca9678-37bd-49f3-a5c1-028e91df984e", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "06eaef56-b035-4bdb-aec4-dd45e3eae7b8", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d1171fe3-ff84-4612-87fa-ab28fd2caca9", "AQAAAAEAACcQAAAAECRVebP5iMOi8ZXMBlVzvGU395/XGap2a4eAnz2po0Oy0iGSXBpztybtilVA9MM3wQ==", "bad1449f-f120-4b33-93e4-7caa1eb91ae7", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUser",
                table: "Messages",
                column: "FromUser");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_OrderId",
                table: "Messages",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUser",
                table: "Messages",
                column: "ToUser");
        }
    }
}
