using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaZakupow.Server.Migrations
{
    public partial class Product_ProductCategory_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductsCategory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCategory_ProductId",
                table: "ProductsCategory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCategory_Products_ProductId",
                table: "ProductsCategory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCategory_Products_ProductId",
                table: "ProductsCategory");

            migrationBuilder.DropIndex(
                name: "IX_ProductsCategory_ProductId",
                table: "ProductsCategory");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsCategory");
        }
    }
}
