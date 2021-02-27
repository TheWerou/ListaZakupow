using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaZakupow.Server.Migrations
{
    public partial class QuickFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductPrice",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrice",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductPrice");
        }
    }
}
