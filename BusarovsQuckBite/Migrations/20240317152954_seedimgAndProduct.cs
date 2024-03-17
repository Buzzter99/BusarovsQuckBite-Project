using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class seedimgAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Img",
                columns: new[] { "Id", "FullPath", "Name" },
                values: new object[,]
                {
                    { 1, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\download.jpg", "download.jpg" },
                    { 2, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\global_tuborg-green.png", "global_tuborg-green.png" },
                    { 3, "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\hamburger-baked-in-oven.jpg", "hamburger-baked-in-oven.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 1, 4, "Pizza", 1, false, "Pepperoni Pizza", 15.00m, 10, new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3042), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 2, 3, "Beer", 2, false, "Tuborg Beer", 5.00m, 50, new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3055), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageId", "IsDeleted", "Name", "Price", "Quantity", "TransactionDateAndTime", "Who" },
                values: new object[] { 3, 2, "Burger", 3, false, "Hamburger", 8.50m, 15, new DateTime(2024, 3, 17, 17, 29, 53, 732, DateTimeKind.Local).AddTicks(3058), "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "85b777ef-cf1a-434d-8516-f2eb838346f2", new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "83aa2e4c-a176-4f18-b92a-aeed1a5ef9d9", new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "dec71b80-f895-41fb-bb3e-a7878ab50b69", new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "f56e5e3a-26d9-4269-b5db-b473543166d8", new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "73043a34-e9c3-438c-93f2-6aefe23e9c77", "AQAAAAEAACcQAAAAEGZKFeIPnSHAxsVCshkhz4xS6Cr//Ql1gcyYxcJu+ccrb4vQIRo2u1ZgzurfQ1sMtA==", "adab7fd3-0f56-4f52-9981-b856b560f608", new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 11, 43, 93, DateTimeKind.Local).AddTicks(5507));
        }
    }
}
