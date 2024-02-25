using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_Who",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_Who",
                table: "Products",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_Who",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_Who",
                table: "Products",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
