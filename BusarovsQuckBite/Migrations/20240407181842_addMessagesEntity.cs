using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addMessagesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromUser = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    ToUser = table.Column<string>(type: "nvarchar(40)", nullable: false)
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
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4ba5aa00-1323-4094-a914-e0baf1f1ecf7", new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "d74b4879-a1e8-4b91-9cb2-768ab9f00944", new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5903c026-666a-4a75-a749-861369306128", new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c58cc0cb-e44c-4969-b3d9-b3e75fe9af12", new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "14a7ca73-34d5-4b3e-8a0d-f043e06c4550", "AQAAAAEAACcQAAAAEBdvSNnGmgGWxQXnL1pxhT2LGkH6c+KM4CblSShJhwC8amWFvBey6e841C5XqK5HrA==", "4cfef3aa-22c7-4e13-95e9-31403826d8dd", new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 593, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 594, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 594, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 18, 42, 594, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUser",
                table: "Messages",
                column: "FromUser");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUser",
                table: "Messages",
                column: "ToUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b58bf979-ee6e-4bea-888a-3122e6b37021", new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5cc21de0-1c6c-42b9-ab1d-a8c92751351f", new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "acfe714b-d39b-477b-a0ee-930d86c50aa4", new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c24b63c3-fb18-421d-b84c-5e08eb6fb744", new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "1f0d2182-bf38-4505-8a87-281906802a8d", "AQAAAAEAACcQAAAAECvi3d9zley8+nKFA/ync/j419NZSmOoAo+miLGH2jIpH6UbNkzJTXAETmFhCNNPww==", "10dbf944-e8a1-462a-8468-d1252a22e768", new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 49, 8, 120, DateTimeKind.Local).AddTicks(8901));
        }
    }
}
