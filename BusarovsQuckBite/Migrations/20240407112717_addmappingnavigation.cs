using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addmappingnavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetRoles",
                type: "nvarchar(40)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "167d08a2-9740-4341-bbb9-28a3346b626b", new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b046a53d-16f9-4fe0-9b67-5b00c73f3f9a", new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "e569f4bc-ad6f-49a3-83fb-b9d6458a3b9f", new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "08e23d9a-2ea6-43bf-9734-2dd7a5b03c32", new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "ef735530-3a42-48db-8ca4-a3b7df84f340", "AQAAAAEAACcQAAAAELoMN1HkgMNGz3phavDE8eybSZfMtyBnnQ+Nqo2UUt20zS6yDh/vHjhtn9UWiyE+zg==", "feb8fe92-01df-481e-a14f-f61f145314a3", new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 17, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 18, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 18, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 27, 17, 18, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                table: "AspNetRoles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetRoles");

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
                values: new object[] { "d7b8e430-28ac-4070-9a6f-1e00a5577965", new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "21ad7f1e-13cc-47b1-b543-de1ff7695de8", new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "188a99ac-fbd2-4f20-909d-44fcad31c33f", new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b88a8a13-0025-4fa9-bebd-a465417ec131", new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "5fbf8659-d14a-4f9b-887b-f6b50ff8f08a", "AQAAAAEAACcQAAAAEBJLEzPZAa89f50HI+3pg07lgfcw61a39eNbiPf5dxoK8hSL91unZkLPK+P5T/95vA==", "142d1769-2725-4fa0-8355-8e79d6277428", new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 14, 36, 82, DateTimeKind.Local).AddTicks(4588));

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
    }
}
