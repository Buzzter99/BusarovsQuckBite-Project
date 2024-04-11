using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changedata : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Img",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullPath", "Name" },
                values: new object[] { "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/tuborg.jpg", "tuborg.jpg" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "0b02ca08-9bc0-41e8-87bb-0b2dd06a994e", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9f046e10-8976-4c8c-9067-d34f541a05b6", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c81f6383-2847-47c8-9907-debdba1106b3", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "a16fcd3f-0e64-45bf-a83a-45a3bba40f02", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d2a9e70d-1dfc-481b-b29e-2025007d2f3a", "AQAAAAEAACcQAAAAENsZBv0XU3sssVYrlOz6Ws3ItlGV/TOp/Wc4zNIr1UlDuSzpPnivy2i/+aOuXx0DDg==", "c6b1d80e-4c3b-4214-ab57-aed2e5f24ee4", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullPath", "Name" },
                values: new object[] { "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/global_tuborg-green.png", "global_tuborg-green.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3824));
        }
    }
}
