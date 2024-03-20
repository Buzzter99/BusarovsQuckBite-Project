using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class migratemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ImageId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "76fec398-97be-4e99-94b3-34dbfe2db11c", new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "6289ad7a-7887-4ba5-8913-d3b9d4c8340a", new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "491db2f5-86dc-4c0c-8863-1476c843a33b", new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4d9b856e-0ced-410d-90bb-86cad569821d", new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "6f400a55-bc2c-4641-97bd-4ad9cdf1d3f5", "AQAAAAEAACcQAAAAEI/0n9wRZvwVj4tqNi4XXmfvGv6Rv/0yPMEJKIxaWZRLQe2yCmuIba+Lau/WKQjTXg==", "6008d96a-9cd0-4582-86e1-4411547103d6", new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 2, 9, 43, 199, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ImageId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "6523c8be-e1b6-4cb6-acca-a1cdf6a050eb", new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f1958001-a0db-465f-8844-bc828bc5125a", new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9ef89422-2240-43ab-a224-201a72192e80", new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "efb4dfe8-9ae8-403f-88bf-b4ce99abf124", new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "89f74d9f-2b7c-4452-855c-7760be5bceb6", "AQAAAAEAACcQAAAAECwTtQHunhstz4D6QcjyfAV89Qmku0R3Ry+sZYupUUDxbpn8t4YK7LDFgevJRP8uvg==", "5c811cf3-919b-4fdb-953c-7d8f8c8722ba", new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 39, 7, 566, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId",
                unique: true);
        }
    }
}
