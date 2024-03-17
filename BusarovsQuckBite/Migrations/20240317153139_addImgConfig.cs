using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addImgConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9c0fb66c-c8aa-447d-bb35-9a9c1a9d2101", new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "2cc5b25c-2eda-488b-8bea-ebd1e502aeca", new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5d21d51f-34fd-4e5c-a934-97eb0844b6c1", new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "34cc32bb-1a69-4181-a326-254f2122e587", new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "35b2572e-e415-433e-9635-06cfcf67dee2", "AQAAAAEAACcQAAAAEK7g/JflmY4JAMfX1piZF8F1x8anslA8fMBvniG0IwU2QA9L+3hH5inKIUzl8g5Xkg==", "1a3d750e-cdee-4307-afbc-b97ab8c01bfa", new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3058));
        }
    }
}
