using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addMessagesEntity3 : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "82a140a3-6b3a-4f4d-b979-356608eb0e19", new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "937ac085-2ece-4251-9920-b867ce33b1c0", new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "0c6cb3ef-d471-43ad-8401-860383c5adcd", new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "37d02f8d-d3dd-4378-9875-c6b36d510840", new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "02dda234-0326-472c-bc87-d9745871d976", "AQAAAAEAACcQAAAAEJnmBcagNLTZngrFxpW1v1hgfstUItQhN8nATLyoc/+YbyIRf5yG/ilpBK61RTiE8A==", "a982c427-00c0-4404-92af-c22433d99271", new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 19, 59, 369, DateTimeKind.Local).AddTicks(9124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
