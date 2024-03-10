using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class TryAddNavProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "34116414-dc34-4c83-8589-3b94ecf07fa8", new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "6f4f0838-e338-47f5-8cf5-8c56cbbada7c", new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "20ccd2df-fdef-4d3a-a274-50f1c49c08a6", new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "2bd41f8a-4864-4e1f-868b-9df19d95ffa0", new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "c7a6801a-06f3-4246-8ddf-b5da0467f6d6", "AQAAAAEAACcQAAAAELpWTWDKUf2Qsh8b/ygFTWKaZ6oFUvnfZAvMmr/iOKLuVjtObpmDuYlzwExQhimv3w==", "7c3619a9-70e1-46a5-bec2-70aee02176df", new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 52, 20, 532, DateTimeKind.Local).AddTicks(2450));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "877c70eb-f2fd-482d-95cf-79b30ebdf97c", new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "d902c26c-1a74-4c5c-99c2-63a7ec4d9a78", new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "d06a2140-10f3-43f6-a6c0-ce935536244a", new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "59ac14f9-69df-4c18-a73f-92551c40bee2", new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "e07e89e6-ac63-49c6-a403-ceaa047e52fd", "AQAAAAEAACcQAAAAELH/VqjUMbKygTOtiFCxQvPCL5xIrB2kmOSKG13nPvIPpsb2Qxnzp9w3UkAbl0CjWg==", "19fd3322-c095-458c-ba30-268d838942db", new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 10, 20, 43, 33, 797, DateTimeKind.Local).AddTicks(7872));
        }
    }
}
