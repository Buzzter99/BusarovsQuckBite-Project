using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addMessagesEntity2 : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUser",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUser",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "85a36f27-6686-4f78-8766-88700a8b0e96", new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ac5b6ab6-3bf7-4cc8-a1a8-c871c2449320", new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "6b3509c1-1808-4232-a8cc-d890ef5f7cf4", new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "d85afa47-a143-4f98-810b-1c5a92be5aec", new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "67b3b07c-8c32-40dc-8a2e-d05da6bf6f67", "AQAAAAEAACcQAAAAEIsXfxu7oDaS3kthE+kMD7NqQCi86z6Ajiqn58Nu3mHgKJoKILusZjeKAubfSzLoCQ==", "cd4d3ab4-99eb-40d3-87a8-05e27b11b845", new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 32, 329, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUser",
                table: "Messages",
                column: "FromUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUser",
                table: "Messages",
                column: "ToUser",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUser",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUser",
                table: "Messages");

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
    }
}
