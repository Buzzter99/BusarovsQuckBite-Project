using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addnavigationinrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationRoleId",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "cb4fc4f6-4bb7-4c7c-8581-68b01ab099c5", new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "bc067c49-a63e-4af4-a76c-46be242c9fbf", new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b42b1db1-b825-4c49-90f1-20869f192b63", new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8f76a84a-8eb6-4d6c-89b4-bb1a580a5a65", new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "b95e0250-af83-44aa-bb6c-e3b8771250b9", "AQAAAAEAACcQAAAAEA4eihwFXWdx1mvTrGGAk8mkY2vFSHk3JAbU/LBhj4ANv4a7N9RrJ57xDlFGlnKqOw==", "afc32de4-1891-4eda-82a1-5a6c2763fe1d", new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 8, 0, 838, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationRoleId",
                table: "AspNetUserRoles",
                column: "ApplicationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_ApplicationRoleId",
                table: "AspNetUserRoles",
                column: "ApplicationRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_ApplicationRoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationRoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationRoleId",
                table: "AspNetUserRoles");

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
        }
    }
}
