using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class switchColumnPlacesOnChronologyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OldStatus",
                table: "OrdersActionChronology",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NewStatus",
                table: "OrdersActionChronology",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OldStatus",
                table: "OrdersActionChronology",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NewStatus",
                table: "OrdersActionChronology",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8c130bd5-3e5b-4012-a140-5927a3a00a9a", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ddd0d8d6-9cb5-480d-8f37-5e825011376c", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "87845f59-25f0-4500-9537-820b4091ff07", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "dd603127-1af2-466c-9109-de6709e50e59", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d93d8b8d-e783-4cb0-ba3b-31fae8744e08", "AQAAAAEAACcQAAAAENbtNZGm0AHo3zeukn6kByWzjtF3gkS6GHNX/yQOHS78erOMDOlHAfcylN45fkGX9A==", "29c3e806-2f8f-49f3-af98-6f5e3a828da5", new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 8, 21, 13, 15, 17, DateTimeKind.Local).AddTicks(2054));
        }
    }
}
