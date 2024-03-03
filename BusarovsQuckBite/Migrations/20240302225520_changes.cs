using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "895d3018-75a9-48a1-a6c9-0048fc1acb15", "AQAAAAEAACcQAAAAEA/z+xNsB9YUHkg6NEu9yhYxkOeHX0mKFM7KGJXva+fpfoNJJ/oE5bgriA+fMPd9bw==", "419d2eae-548c-4acb-a1c5-c377a1cadeaf", new DateTime(2024, 3, 3, 0, 55, 19, 793, DateTimeKind.Local).AddTicks(720) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f95134b6-68f6-45b6-a9e2-96635e769faa", new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "42fd3cac-5ac1-43d1-bae3-935fdf3ab6c1", new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "651696f4-54ae-4c69-abdb-87153cd84cf4", new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4e39bff2-9750-43a6-9e07-99d4e0959c57", new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "602950b8-a951-4434-9231-ae7f551ea780", "AQAAAAEAACcQAAAAEMAAFTsIKkVMm2sTpXkTJ/rOQiwUn9f7tYCPDwObSbIP9bS8QTOzoBKkK0axrPxaaQ==", "a2819faf-a765-42dc-9f38-689dc07425eb", new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 1, 23, 28, 28, 43, DateTimeKind.Local).AddTicks(5500));
        }
    }
}
