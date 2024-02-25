using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class ChangeNamesOfPRoperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_Orderer",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Orderer",
                table: "Orders",
                newName: "Who");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Orderer",
                table: "Orders",
                newName: "IX_Orders_Who");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Categories",
                newName: "Who");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                newName: "IX_Categories_Who");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_Who",
                table: "Orders",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_Who",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_Who",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Who",
                table: "Orders",
                newName: "Orderer");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Who",
                table: "Orders",
                newName: "IX_Orders_Orderer");

            migrationBuilder.RenameColumn(
                name: "Who",
                table: "Categories",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Who",
                table: "Categories",
                newName: "IX_Categories_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_Orderer",
                table: "Orders",
                column: "Orderer",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
