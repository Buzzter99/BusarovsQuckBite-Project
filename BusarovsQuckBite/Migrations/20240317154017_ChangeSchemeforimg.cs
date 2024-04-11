using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class ChangeSchemeforimg : Migration
    {
        [ExcludeFromCodeCoverage]
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Img",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/download.jpg", "~/Images/" });

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/global_tuborg-green.png", "~/Images/" });

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/hamburger-baked-in-oven.jpg", "~/Images/" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "3a601b22-b9fe-456d-ac6f-716cbd3fc473", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "5590b7a4-30ff-4c55-acf5-7b12c8192f7d", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "ff84162d-80c6-417f-8d65-ab3b186e6b95", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa175b24-e5a7-41ab-8237-94734f2b5408",
                columns: new[] { "ConcurrencyStamp", "TransactionDateAndTime" },
                values: new object[] { "050a8cb4-cca3-41c0-a04b-eecba015d223", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TransactionDateAndTime" },
                values: new object[] { "c708d830-20f0-417e-b9c7-21dce729c2a5", "AQAAAAEAACcQAAAAEP5vZ/P6dSqDJ1b1C/OVGilSwM/N+XLD8flM4rbeBplqeBZGbjCV4uwxzDNZrVwYHQ==", "a4ec8f2f-e8b9-41bf-9163-fbdf007bf29c", new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\download.jpg", "@~/Images/" });

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\global_tuborg-green.png", "@~/Images/" });

            migrationBuilder.UpdateData(
                table: "Img",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FullPath", "RelativePath" },
                values: new object[] { "C:\\Users\\GRIGS\\source\\repos\\BusarovsQuckBite\\BusarovsQuckBite\\wwwroot\\Images\\hamburger-baked-in-oven.jpg", "@~/Images/" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDateAndTime",
                value: new DateTime(2024, 3, 17, 17, 37, 8, 454, DateTimeKind.Local).AddTicks(6709));
        }
    }
}
