using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class testScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "9f1a47bb-b51a-4547-a713-60edfa13eaee", "CfDJ8HeH4f54VCZHnfY0KvPjmDhMMBcNwki7Gr45dKMMS3DZw-4DfOcQ3N0gUxFjQfLrAtpudMHdkuAKTPIuyb-TOAD_mVx9PqjLg1Rd1lOT-nigm5S-SL6o6ZzqBdslOF2-IUVg2xgr01jiVtnbMNZn6Xg", "AQAAAAEAACcQAAAAEK02ybmaqeMUHSCJfeCI3lQAaMcmElHtItsHthSWZxWOE6oMKlg2GkwgxfvYeW7dQg==", "CfDJ8HeH4f54VCZHnfY0KvPjmDijMmM4PDxZTqnc14Bakn2OkZu7OUU9TuUyJQaWQuQgK7EmwK5KAFVMYLmPr4S55n1kN3Hah_G4kYw61faG3Xvg8pD_HntZVrYcU9sAzYExUA", "ab3281d7-6071-4d01-ad3b-00957d6ea838", new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2100), "CfDJ8HeH4f54VCZHnfY0KvPjmDiq1Ra4X4GdiF3C23ddCTcdL-wp5bwuq9w5YRfsEqwPsq9rWtrmthuh0ERH3YCSgr95FZkZK_MjhRxhA06slug-kS7ijHhQQCg6sBMKfMXyZw" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "PhoneNumber", "SecurityStamp", "TransactionDateAndTime", "UserName" },
                values: new object[] { "c1bc7f2a-6caf-4dd0-a7e9-c7d1875bb7b6", "CfDJ8HeH4f54VCZHnfY0KvPjmDgBKnlBxrFDg5JlPQDSA6EqqUlpDNpWmBFVo8CBEdMXTZTK7SQMxlTS5rj8elETATkP4hkdKIPgajrR49bTW5t8E84sta9bMHROfGDsSmi_7fXeOR1BeRadGJ5PTL8PFsA", "AQAAAAEAACcQAAAAEAWnYqO7wSiXK1ZKe41MwWLGyTgW8DWUWabz3NBgkZxS4bhQrEuIB9hPhU5sUJLsEA==", "CfDJ8HeH4f54VCZHnfY0KvPjmDgIwltKj6S9nqC2AhvP6FUGO_DM1W-Zo4CCMKPb2ZYF88vse7pLIXP5H_WiGd_BbvQ9uAZu1s2SGA1ypOQYtRl43SctpqlyUB99QUT9V0yJVw", "3d9a3640-1a4e-4fe3-aa4d-8b024c663ce3", new DateTime(2024, 3, 7, 23, 16, 15, 754, DateTimeKind.Local).AddTicks(1730), "CfDJ8HeH4f54VCZHnfY0KvPjmDh5tVnpVR4hoxW0Omw0fJx3Lr8NvJHYS8wAP4KOI6NbuKApkmxuUnlk8NqlSiInc9DevvNH-pFTUzi4SqIWgp5zf4Nl5238JQH84fgv_1DZJQ" });

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
    }
}
