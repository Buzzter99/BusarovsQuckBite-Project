using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class LatestDbChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProducts_Cart_CardId",
                table: "OrdersProducts");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "OrdersProducts",
                newName: "CartId");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cart_CartId",
                table: "Orders",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Cart_CartId",
                table: "OrdersProducts",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cart_CartId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProducts_Cart_CartId",
                table: "OrdersProducts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "OrdersProducts",
                newName: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Cart_CardId",
                table: "OrdersProducts",
                column: "CardId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
