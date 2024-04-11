using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addmappingnavigation4 : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "bc80c9d3-3bcc-4265-9964-89718166d130", new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "451c5522-0660-41a7-b0ed-c7f78ccf8ba8", new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "6a25cfc0-8a1d-4229-89df-8887a8eb6504", new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "d5207296-06fa-4bb9-bacf-0b2e8677ea32", new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "5ca70548-d1ba-42f9-b14b-a6c411233156", "AQAAAAEAACcQAAAAEOL0B2eDRN0nXqfuRYJgD2Il0fbGpUGTXs006BA4AP/NyQZLoL39ByHVVJRFPik3Bg==", "e445a8f3-c9dd-4159-ab59-d6e11099f0d6", new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 439, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 440, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 440, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 38, 25, 440, DateTimeKind.Local).AddTicks(461));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "82816615-15d9-4818-9851-1dbc070ba5b1", new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "805f86c3-f2a1-429d-bbf8-c238050240fa", new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c1aca0ff-c271-424a-8a37-4c52ea0c5604", new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b4b55a03-8cfe-415e-8822-bc37b53535e3", new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "fc6c82ac-de3f-48dc-8ea3-94b0ae6c5d8c", "AQAAAAEAACcQAAAAEE8taFAk5wiS9wjmYPX++AcIKghO/xnxO/a0dRjriBc3avs7OOfz9qTAKQNg+V0hFQ==", "99820fa2-8ec7-426b-8446-5fcf6a29ee97", new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 15, 34, 57, 34, DateTimeKind.Local).AddTicks(6155));
        }
    }
}
