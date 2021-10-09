using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_TipoProdutos_TipoProdutoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_TipoProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "TipoProdutoId",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdTipoProduto",
                table: "Produtos",
                column: "IdTipoProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_TipoProdutos_IdTipoProduto",
                table: "Produtos",
                column: "IdTipoProduto",
                principalTable: "TipoProdutos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_TipoProdutos_IdTipoProduto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdTipoProduto",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "TipoProdutoId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_TipoProdutoId",
                table: "Produtos",
                column: "TipoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_TipoProdutos_TipoProdutoId",
                table: "Produtos",
                column: "TipoProdutoId",
                principalTable: "TipoProdutos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
