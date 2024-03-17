using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class AddAdditionInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Img",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullPath",
                table: "Img",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "RelativePath",
                table: "Img",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3a601b22-b9fe-456d-ac6f-716cbd3fc473", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5590b7a4-30ff-4c55-acf5-7b12c8192f7d", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ff84162d-80c6-417f-8d65-ab3b186e6b95", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "050a8cb4-cca3-41c0-a04b-eecba015d223", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "c708d830-20f0-417e-b9c7-21dce729c2a5", "AQAAAAEAACcQAAAAEP5vZ/P6dSqDJ1b1C/OVGilSwM/N+XLD8flM4rbeBplqeBZGbjCV4uwxzDNZrVwYHQ==", "a4ec8f2f-e8b9-41bf-9163-fbdf007bf29c", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 1,
                column: "RelativePath",
                value: "@~/Images/");

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 2,
                column: "RelativePath",
                value: "@~/Images/");

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 3,
                column: "RelativePath",
                value: "@~/Images/");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6709));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelativePath",
                table: "Img");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Img",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FullPath",
                table: "Img",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c158ee04-552a-4435-800a-b9b40f9130b4", new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "08388941-1690-46be-898e-81201f69590d", new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "51f0a1d4-eb70-497d-828e-f5cb77152804", new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "93418e2d-89ed-4669-b294-98e87363ec5c", new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "64a40cba-3a00-4ddc-9f39-f512480b1a37", "AQAAAAEAACcQAAAAEL8bNgbUL35S24j3zoZ5LyABycnkwCOLzITdMwO20T6ztzJo/xYoha/YKDUJov8c4w==", "c62fc055-690e-459e-b8ae-65f1a1aed714", new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 31, 38, 752, DateTimeKind.Local).AddTicks(9311));
        }
    }
}
