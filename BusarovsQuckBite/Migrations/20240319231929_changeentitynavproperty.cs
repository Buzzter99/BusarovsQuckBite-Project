using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changeentitynavproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Img_Products_ProductId",
                table: "Img");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImageId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Img_ProductId",
                table: "Img");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Img");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "0b02ca08-9bc0-41e8-87bb-0b2dd06a994e", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9f046e10-8976-4c8c-9067-d34f541a05b6", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c81f6383-2847-47c8-9907-debdba1106b3", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "a16fcd3f-0e64-45bf-a83a-45a3bba40f02", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "d2a9e70d-1dfc-481b-b29e-2025007d2f3a", "AQAAAAEAACcQAAAAENsZBv0XU3sssVYrlOz6Ws3ItlGV/TOp/Wc4zNIr1UlDuSzpPnivy2i/+aOuXx0DDg==", "c6b1d80e-4c3b-4214-ab57-aed2e5f24ee4", new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 19, 28, 805, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ImageId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Img",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "9ef7318f-6cc4-4f56-90cf-402a897b3124", new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "649cb419-2dd6-487d-bcbf-b187278d95f0", new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "4f81ea52-19cc-4370-8b34-8345a6bbda2e", new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ee58cc08-bf7a-4123-9472-eb531053f1cc", new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "5af0838e-6d60-4de8-a3cd-20d37ff6658e", "AQAAAAEAACcQAAAAEPbvumpIW25z2NXUOpCDRf9xsvDDgzS0OPZFPF5SZpm4A95XrRwBAa1fY9QAnKUrKQ==", "3ed7d21f-230d-4cd9-870b-60475301f391", new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 20, 1, 6, 28, 33, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Img_ProductId",
                table: "Img",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Img_Products_ProductId",
                table: "Img",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
