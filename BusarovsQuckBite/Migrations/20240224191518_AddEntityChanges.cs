using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    public partial class AddEntityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProducts_Cart_CartId",
                table: "OrdersProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProducts_Products_ProductId",
                table: "OrdersProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts");

            migrationBuilder.RenameTable(
                name: "OrdersProducts",
                newName: "CartProducts");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersProducts_ProductId",
                table: "CartProducts",
                newName: "IX_CartProducts_ProductId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Addresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Cart_CartId",
                table: "CartProducts",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Cart_CartId",
                table: "CartProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "CartProducts",
                newName: "OrdersProducts");

            migrationBuilder.RenameIndex(
                name: "IX_CartProducts_ProductId",
                table: "OrdersProducts",
                newName: "IX_OrdersProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Cart_CartId",
                table: "OrdersProducts",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Products_ProductId",
                table: "OrdersProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
