using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class changescheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Addresses",
                newName: "Who");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                newName: "IX_Addresses_Who");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_Who",
                table: "Addresses",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_Who",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Who",
                table: "Addresses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_Who",
                table: "Addresses",
                newName: "IX_Addresses_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
