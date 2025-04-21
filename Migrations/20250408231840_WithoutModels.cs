using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class WithoutModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedProductModels_Orders_OrderId",
                table: "PurchasedProductModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedProductModels_Products_ProductId",
                table: "PurchasedProductModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasedProductModels",
                table: "PurchasedProductModels");

            migrationBuilder.RenameTable(
                name: "PurchasedProductModels",
                newName: "PurchasedProducts");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedProductModels_ProductId",
                table: "PurchasedProducts",
                newName: "IX_PurchasedProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedProductModels_OrderId",
                table: "PurchasedProducts",
                newName: "IX_PurchasedProducts_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasedProducts",
                table: "PurchasedProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedProducts_Orders_OrderId",
                table: "PurchasedProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedProducts_Products_ProductId",
                table: "PurchasedProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedProducts_Orders_OrderId",
                table: "PurchasedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedProducts_Products_ProductId",
                table: "PurchasedProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasedProducts",
                table: "PurchasedProducts");

            migrationBuilder.RenameTable(
                name: "PurchasedProducts",
                newName: "PurchasedProductModels");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedProducts_ProductId",
                table: "PurchasedProductModels",
                newName: "IX_PurchasedProductModels_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedProducts_OrderId",
                table: "PurchasedProductModels",
                newName: "IX_PurchasedProductModels_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasedProductModels",
                table: "PurchasedProductModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedProductModels_Orders_OrderId",
                table: "PurchasedProductModels",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedProductModels_Products_ProductId",
                table: "PurchasedProductModels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
