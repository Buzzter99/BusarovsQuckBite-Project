using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class originalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "36808608-7ee7-4dc1-810e-ce0dd8da946c", new DateTime(2024, 3, 8, 0, 3, 6, 668, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c7defe64-86ce-40ec-b33c-a9bf0725ff86", new DateTime(2024, 3, 8, 0, 3, 6, 668, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "71fab7bd-4e5b-403a-a37e-bad3ca544d4c", new DateTime(2024, 3, 8, 0, 3, 6, 668, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "020ca46a-ec05-4b8b-8896-b87235c9f453", new DateTime(2024, 3, 8, 0, 3, 6, 668, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "42fae123-e949-444d-af41-6de7e057a958", "brandabg1@gmail.com", "BRANDABG1@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOiB+kGiDaFDNjiwvRgCUUkFvcOEUS8JCL5eYaVQRDa4hKaqsC09V3v1zl7rErZ+dg==", "0896722926", "2d9da411-2f44-4b9f-8c56-4731c0044341", new DateTime(2024, 3, 8, 0, 3, 6, 668, DateTimeKind.Local).AddTicks(9714), "Admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 8, 0, 3, 6, 669, DateTimeKind.Local).AddTicks(766));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4e8e9883-48b4-475c-92c5-456476fce2ea", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "fdc0782d-123c-4e3b-b351-11df6dbcbcaf", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "96b728a3-1dea-436b-8915-34c4e8063c28", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "1dfe148c-5d11-432b-827c-6e76c2ebc52f", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "9f1a47bb-b51a-4547-a713-60edfa13eaee", "CfDJ8HeH4f54VCZHnfY0KvPjmDhMMBcNwki7Gr45dKMMS3DZw-4DfOcQ3N0gUxFjQfLrAtpudMHdkuAKTPIuyb-TOAD_mVx9PqjLg1Rd1lOT-nigm5S-SL6o6ZzqBdslOF2-IUVg2xgr01jiVtnbMNZn6Xg", null, null, "AQAAAAEAACcQAAAAEK02ybmaqeMUHSCJfeCI3lQAaMcmElHtItsHthSWZxWOE6oMKlg2GkwgxfvYeW7dQg==", "CfDJ8HeH4f54VCZHnfY0KvPjmDijMmM4PDxZTqnc14Bakn2OkZu7OUU9TuUyJQaWQuQgK7EmwK5KAFVMYLmPr4S55n1kN3Hah_G4kYw61faG3Xvg8pD_HntZVrYcU9sAzYExUA", "ab3281d7-6071-4d01-ad3b-00957d6ea838", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2100), "CfDJ8HeH4f54VCZHnfY0KvPjmDiq1Ra4X4GdiF3C23ddCTcdL-wp5bwuq9w5YRfsEqwPsq9rWtrmthuh0ERH3YCSgr95FZkZK_MjhRxhA06slug-kS7ijHhQQCg6sBMKfMXyZw" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3513));
        }
    }
}
