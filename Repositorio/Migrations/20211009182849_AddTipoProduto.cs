using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddTipoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" insert into TipoProdutos values ('Alimento');" +
                "insert into TipoProdutos values ('Outros');" +
                " insert into TipoProdutos values ('Limpeza'); ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
