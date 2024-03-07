using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addEncryption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "fcb48484-eb58-4d92-b291-12cf2bdecb5d", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "87132b28-a333-4fa3-b3c0-b2d46519aee0", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4a3d7235-02d6-4103-8a2f-5efdbed1e0f9", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "bfd9f455-b0c6-46e5-9b3c-339de53fb179", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "c1bc7f2a-6caf-4dd0-a7e9-c7d1875bb7b6", "CfDJ8HeH4f54VCZHnfY0KvPjmDgBKnlBxrFDg5JlPQDSA6EqqUlpDNpWmBFVo8CBEdMXTZTK7SQMxlTS5rj8elETATkP4hkdKIPgajrR49bTW5t8E84sta9bMHROfGDsSmi_7fXeOR1BeRadGJ5PTL8PFsA", true, null, "AQAAAAEAACcQAAAAEAWnYqO7wSiXK1ZKe41MwWLGyTgW8DWUWabz3NBgkZxS4bhQrEuIB9hPhU5sUJLsEA==", "CfDJ8HeH4f54VCZHnfY0KvPjmDgIwltKj6S9nqC2AhvP6FUGO_DM1W-Zo4CCMKPb2ZYF88vse7pLIXP5H_WiGd_BbvQ9uAZu1s2SGA1ypOQYtRl43SctpqlyUB99QUT9V0yJVw", "3d9a3640-1a4e-4fe3-aa4d-8b024c663ce3", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(1730), "CfDJ8HeH4f54VCZHnfY0KvPjmDh5tVnpVR4hoxW0Omw0fJx3Lr8NvJHYS8wAP4KOI6NbuKApkmxuUnlk8NqlSiInc9DevvNH-pFTUzi4SqIWgp5zf4Nl5238JQH84fgv_1DZJQ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(3241));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3fc10c5e-824a-41a9-840e-49df5ca13449", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "7c92d776-95ca-430c-82d6-bce023b174de", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c90432d9-1e66-454f-9199-38703ba2f6cb", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "7239e349-9202-44b1-ae0d-082d60e3da2c", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "895d3018-75a9-48a1-a6c9-0048fc1acb15", "brandabg1@gmail.com", false, "ADMIN", "AQAAAAEAACcQAAAAEA/z+xNsB9YUHkg6NEu9yhYxkOeHX0mKFM7KGJXva+fpfoNJJ/oE5bgriA+fMPd9bw==", "0896722926", "419d2eae-548c-4acb-a1c5-c377a1cadeaf", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(720), "Admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(2006));
        }
    }
}
