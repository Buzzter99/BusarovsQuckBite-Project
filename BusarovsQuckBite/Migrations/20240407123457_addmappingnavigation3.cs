using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addmappingnavigation3 : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

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

            migrationBuilder.InsertData(
                table: "IdentityUserRole<string>",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "ApplicationUserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9", null });

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
    }
}
