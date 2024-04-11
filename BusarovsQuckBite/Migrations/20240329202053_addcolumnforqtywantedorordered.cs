using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addcolumnforqtywantedorordered : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtyOrdered",
                table: "OrdersProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b6ea216a-c833-4acc-8fc4-8a071ad56772", new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "33ad5f26-9b97-4bd0-8b63-273cce9a3cfb", new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f9e261f8-1610-4780-8e5d-b378d2fdf60a", new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c630af76-435a-43d8-84f3-77cf54ba435c", new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "9fd9e518-244f-4143-96bd-9b2a7292d687", "AQAAAAEAACcQAAAAEH6XQhI9teFBaTNlnKrEnZup7SFzFAaxiLQBELxzC8Fj5c8nppEo6acVaN5SvZ5x5Q==", "b971d0c2-e131-430d-866f-b126b6dbe7df", new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 29, 22, 20, 53, 252, DateTimeKind.Local).AddTicks(4503));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtyOrdered",
                table: "OrdersProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "1036e52f-1a22-4e62-a891-bef2942b2218", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "185d601e-2f9a-451a-a740-11eec522ebdf", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "061e1e9d-2084-4f1f-90af-624ac5936c36", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8b362563-a94e-4647-91ed-f7f67ffaa796", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "5c449abf-1e6f-4f8f-a454-75280bae0e07", "AQAAAAEAACcQAAAAEJGP99hgNAwARKcyVnikvNDmzfySLe7zqivheyZNlYKYkM0Cyr09fMNEBGZNjMMqAw==", "bfc91459-7a84-44a7-8fa7-bcbaed4e1aa1", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6852));
        }
    }
}
