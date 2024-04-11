using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addPaymentTypeForOrders : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3410ff36-5bcc-478b-a842-307b20fa2dca", new DateTime(2024, 3, 24, 16, 22, 19, 650, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9b7edcfc-2739-4c9a-9990-26cbb9ab858d", new DateTime(2024, 3, 24, 16, 22, 19, 650, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "0e069632-dc52-4f05-b325-37f5a0143f18", new DateTime(2024, 3, 24, 16, 22, 19, 650, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c139a29a-be05-4c95-ab3e-ebacda0dce6d", new DateTime(2024, 3, 24, 16, 22, 19, 650, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "bc829828-09a6-44c2-850f-79f97a72712b", "AQAAAAEAACcQAAAAEPBNHOsDqxRv5Xr3si7JPEVBUy1ZCH5XBDDX80D0kemLw4j+4k/Hgj7OBSZRWCUrTA==", "cada11d3-b130-4be1-8c96-6d7cc7f4281b", new DateTime(2024, 3, 24, 16, 22, 19, 650, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 16, 22, 19, 651, DateTimeKind.Local).AddTicks(2749));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ba58cbfe-eb45-47ed-be99-06c189d374e1", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "00016d57-0e4f-4e61-9e1d-c99ec1b81cb5", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "45fb62b3-de8c-4a87-b9e7-1053dfe77910", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3cdd642b-c948-40eb-b111-3b21c92ba216", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "bed9af26-c311-4532-bc6a-d941c74add8d", "AQAAAAEAACcQAAAAEM51odiWJEm2cuJFTVtGmVAZ7Njs0Xw0M3kbc5NNoJJQu2fF+Li06nkriwNOe+/IcA==", "92483a0c-6150-4503-bcdb-d0ce050302db", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5982));
        }
    }
}
