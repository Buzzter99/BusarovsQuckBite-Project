using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class removeWantedQtyProp : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WantedQty",
                table: "CartProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ba58cbfe-eb45-47ed-be99-06c189d374e1", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "00016d57-0e4f-4e61-9e1d-c99ec1b81cb5", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "45fb62b3-de8c-4a87-b9e7-1053dfe77910", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3cdd642b-c948-40eb-b111-3b21c92ba216", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "bed9af26-c311-4532-bc6a-d941c74add8d", "AQAAAAEAACcQAAAAEM51odiWJEm2cuJFTVtGmVAZ7Njs0Xw0M3kbc5NNoJJQu2fF+Li06nkriwNOe+/IcA==", "92483a0c-6150-4503-bcdb-d0ce050302db", new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 24, 0, 4, 49, 615, DateTimeKind.Local).AddTicks(5982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WantedQty",
                table: "CartProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "cb384c68-2d66-4e22-af44-64c8bb5f51e3", new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "48fa22ca-885b-4965-b4d7-1d6d8e312e5d", new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "7a331aa8-271e-49db-97a1-9d1d69cc069a", new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "27312c1e-01c2-41eb-99de-230dca2d531f", new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "19463ca9-c9ee-4589-b406-4394eb0f7e3e", "AQAAAAEAACcQAAAAEK6ugY92SOjtJ2Bsddkzl8igaWK+ZrcVaQfKXHNg4PamQAKP22ISD5YZJjn0tZvQpw==", "c5831913-b64f-4171-b18a-bb3c1c4474ff", new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 56, 22, 91, DateTimeKind.Local).AddTicks(5919));
        }
    }
}
