using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addColumnToMessage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ba08325d-1071-407b-afb9-f8074c29130f", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "032b18a2-001c-4545-a610-8d9c0d3fdd45", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "62ca9678-37bd-49f3-a5c1-028e91df984e", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "06eaef56-b035-4bdb-aec4-dd45e3eae7b8", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d1171fe3-ff84-4612-87fa-ab28fd2caca9", "AQAAAAEAACcQAAAAECRVebP5iMOi8ZXMBlVzvGU395/XGap2a4eAnz2po0Oy0iGSXBpztybtilVA9MM3wQ==", "bad1449f-f120-4b33-93e4-7caa1eb91ae7", new DateTime(2024, 4, 7, 22, 7, 1, 964, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 4, 7, 22, 7, 1, 965, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Orders_OrderId",
                table: "Messages",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
