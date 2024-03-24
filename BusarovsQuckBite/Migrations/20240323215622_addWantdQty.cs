using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addWantdQty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WantedQty",
                table: "CartProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "cc97fc37-ab14-4c49-bea9-25cb0b702aad", new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "cc6c3972-614c-4c39-bbc5-64804a32740d", new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "2be50fc1-697c-4b1a-b7cb-889c6f4e835b", new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "b6ff975d-47e4-4cdc-91d5-2a5fcdedee67", new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d781faa2-be88-41b1-906f-ca0f074ff6f6", "AQAAAAEAACcQAAAAEAGbif0FWwc0XJbQJ4FJGB0EyWpra20Iih/R9usdP+k9SXComDgv+EqdEEtngBQ3IQ==", "0c7dcb56-a249-4fdc-8b09-c334ec03dc54", new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9102));
        }
    }
}
