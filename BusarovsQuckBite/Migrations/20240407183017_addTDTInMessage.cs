using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addTDTInMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDateAndTime",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "96826948-10df-4347-b1fe-542e8d894532", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "bedaf1ab-c084-4701-bbc3-1b0374ec08a5", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "e29d936d-33c5-4fd4-93fc-bdf4859b4d68", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5724d2cb-01f7-4a03-8405-b0188510fd15", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "1545654d-3a52-44ee-9585-d467cf943018", "AQAAAAEAACcQAAAAEEQzgOLzBs7zjZ5JKl1UK/+X/DlF72VURawqtVEkS4tHX6jtsxISIUU6Lh33V0mYGA==", "1aca05c6-9acd-40c5-acaf-18e9f1d6f1fd", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2643));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDateAndTime",
                table: "Messages");

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
    }
}
