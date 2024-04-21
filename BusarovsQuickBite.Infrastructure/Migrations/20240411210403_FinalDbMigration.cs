using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class FinalDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "49062c31-364a-42f1-9147-805838a8640d", new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "267c6008-1461-4e0f-9e07-068765e17e19", new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "76ef281a-5e37-47ef-853a-75d71a42e918", new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "a35b1808-bd22-41c5-b328-87e6a2a793fa", new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "696d5645-44c9-4f61-923f-c5647365782d", "AQAAAAEAACcQAAAAEFFhgkflTkDGHKHaRGuSStmGuaeA0NGh3ZKzlIKI5H7xOHgeNQupgD0ZLZ+SW7xeBQ==", "e18232a5-5421-4b82-a785-e9dd50c46e75", new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 12, 0, 4, 3, 406, DateTimeKind.Local).AddTicks(3648));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "7fc001d3-1626-491a-a54f-abd6bb6df32a", new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "cb11c394-9ab6-489d-b43f-92f57ef1b578", new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4b39e9dc-e891-4319-94c7-a16c56718b7a", new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "502f51bf-0586-4c9d-a91e-5326be31659e", new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "3028dabe-ae82-467d-8683-e5879eeeade6", "AQAAAAEAACcQAAAAEGz0eC5p8xLuMq6QEgdW9IaNdPl/sOsbZg26JXO+9L8EoWZzU5Z1V1nBWCO7+r+zCg==", "ca2d86b6-0f20-4e04-a849-097bbe314afb", new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 17, 10, 944, DateTimeKind.Local).AddTicks(4754));
        }
    }
}
