using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addpropsfororder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "1036e52f-1a22-4e62-a891-bef2942b2218", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "185d601e-2f9a-451a-a740-11eec522ebdf", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "061e1e9d-2084-4f1f-90af-624ac5936c36", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8b362563-a94e-4647-91ed-f7f67ffaa796", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "5c449abf-1e6f-4f8f-a454-75280bae0e07", "AQAAAAEAACcQAAAAEJGP99hgNAwARKcyVnikvNDmzfySLe7zqivheyZNlYKYkM0Cyr09fMNEBGZNjMMqAw==", "bfc91459-7a84-44a7-8fa7-bcbaed4e1aa1", new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 20, 29, 4, 747, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8793900e-b3e0-4522-9fe5-db8fcf8e5fc1", new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "7db3445c-7a7e-4f16-a5d1-7b4e20ed8ac3", new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c5795b6a-2de3-487a-aa5e-e3b72b829dda", new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "8382890c-bbe2-475c-83dc-4f6c7d6d1d0b", new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "7893091e-b0aa-4854-b71d-acc748e69ffd", "AQAAAAEAACcQAAAAEGihEjloA8biEsNGynT6wBw1sOk/RUhy2Z7MLdpweWMIzJfv/gpQKskjPIgCjGwTDg==", "09470f95-6d08-4799-9d1b-9ab09c69dbd7", new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 26, 19, 59, 4, 887, DateTimeKind.Local).AddTicks(6038));
        }
    }
}
