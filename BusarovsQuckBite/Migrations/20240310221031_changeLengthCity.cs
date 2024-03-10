using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changeLengthCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5fcfb600-50d8-43b2-9e40-ca8a459edb45", new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "053d0133-c1bf-4e88-84f0-7341fa631790", new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c29129fd-5472-4880-a626-92b57dade153", new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "fe7670f0-26d1-4ce4-a518-e1f0469f1dde", new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "c0ba3068-7237-4abb-a950-269fdc0803e8", "AQAAAAEAACcQAAAAEP/XGnmWATAGPQTrvgH3EMkSJcTXEPHnBGucECMz7BtvtAfTq6LKKyr02hnmsb4kAA==", "c5a86a4a-73e3-4348-b32a-aa85ef728267", new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 11, 0, 10, 31, 505, DateTimeKind.Local).AddTicks(3311));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "07aed199-54c1-4f26-9f31-62ea73ff080d", new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "96fa4f3b-e7b3-40ab-be93-e805fbebd0f9", new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "232d6b13-3595-4c78-982f-9a5fd5152287", new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f24ba58f-5c6f-42f1-8237-0ba2f5696625", new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d9925477-3a77-4066-a7c4-644f0cd881a9", "AQAAAAEAACcQAAAAEI73FCEr+cRa7I4kJlymfvPMxcBY2oq2rlQ5Q5y7od8EbbEVEpmIMHnKFGi7wbVQfw==", "47f93891-d062-41c3-a3df-5da97d8c23bc", new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 21, 33, 5, 992, DateTimeKind.Local).AddTicks(1643));
        }
    }
}
