using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addmappingnavigation1 : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3fb79dc5-a063-43da-aaa1-6ac6322a9ae5", new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "676e6234-e5fc-42df-adfa-819483b835bd", new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f0358c9c-52d5-4760-bd49-812f7d002560", new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f85f4e08-97f3-4a07-9bc9-ca147c966b62", new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d05244d7-4474-4376-9eb7-bc6ed2eaa070", "AQAAAAEAACcQAAAAEFXMnlLzYiewRYqmpdhGshcTGzOZ/Dd1kw+AvKSiPiEagenp3jKzoK/7J/qqgqNKqg==", "c0bd67aa-3c2c-4725-91e4-014c3434f720", new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 14, 30, 14, 997, DateTimeKind.Local).AddTicks(5097));

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
    }
}
