using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addnavigationforrolesidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserRoles",
                type: "nvarchar(40)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "07722582-8d10-4a19-ad8b-ed1d56e712b0", new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "25dee619-558b-451e-a0a1-f294335d13c8", new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "0f308d76-6357-4e60-ab28-b21332eef9c9", new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5294c813-a37e-4a9b-b08b-53093df5ed98", new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "4decfaeb-c7f2-47b8-97c0-e367f69b71e2", "AQAAAAEAACcQAAAAEFgx+rdg2zl0iyxPorQHrnbJ1okvOc8bh8EGodVBdBmcrJ9SfVC1FZ7wKtF5JATcbw==", "ad94fbfc-bedb-4381-998d-f6d49c3c1504", new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 13, 59, 45, 864, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles");

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
    }
}
