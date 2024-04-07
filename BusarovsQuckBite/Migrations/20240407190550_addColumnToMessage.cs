using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addColumnToMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUser",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUser",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f7482e57-7874-418f-9aa3-97818d371177", new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ed80a42c-cded-4372-a970-7e7343431052", new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "a4956268-85b4-4b31-93e0-2a797f620a07", new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "a0014e1b-50ac-4ae8-89f0-b1e13bf46917", new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "65e77d71-939e-4680-873a-12221df8db7c", "AQAAAAEAACcQAAAAENXwgbx3UyLrER+FfvcZgjs5N9oOL+yXiUOfx21rG2Nd499kGOIFLjVw/3F5kYcp3Q==", "4df4528a-0bca-4856-9e58-d1e5a5c3735b", new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 5, 50, 16, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUser",
                table: "Messages",
                column: "FromUser");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_OrderId",
                table: "Messages",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUser",
                table: "Messages",
                column: "ToUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUser",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_OrderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUser",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "96826948-10df-4347-b1fe-542e8d894532", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "bedaf1ab-c084-4701-bbc3-1b0374ec08a5", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "e29d936d-33c5-4fd4-93fc-bdf4859b4d68", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5724d2cb-01f7-4a03-8405-b0188510fd15", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "1545654d-3a52-44ee-9585-d467cf943018", "AQAAAAEAACcQAAAAEEQzgOLzBs7zjZ5JKl1UK/+X/DlF72VURawqtVEkS4tHX6jtsxISIUU6Lh33V0mYGA==", "1aca05c6-9acd-40c5-acaf-18e9f1d6f1fd", new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 21, 30, 16, 709, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUser",
                table: "Messages",
                column: "FromUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUser",
                table: "Messages",
                column: "ToUser",
                unique: true);
        }
    }
}
