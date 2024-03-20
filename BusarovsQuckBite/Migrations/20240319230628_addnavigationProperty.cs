using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class addnavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Img_Products_ProductId",
                table: "Img");

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
                values: new object[] { "b4d00143-b984-4c19-b478-2add6d9f7d1a", new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "2920bbdf-90cb-4702-b315-ee0eb0721415", new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "c0354bff-3b49-42d5-9121-74b9b2194a53", new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "707946d8-52b9-4284-a4f8-fc31a1b999e6", new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "b644fbfb-9e04-44ae-9941-8178a33315a4", "AQAAAAEAACcQAAAAEHaNyBRjqBiUKArv/+lx02Am1/yePLyTL4UV7LT4pg0oxmukJcTm/XI9e/e7I6mDCQ==", "9c96e412-5b3d-44db-9b76-949a2f27fa7a", new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 40, 16, 870, DateTimeKind.Local).AddTicks(7580));
        }
    }
}
