using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazingChocolate.Infrastructure.DataAccess.Migrations
{
    public partial class inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Clientes");
        }
    }
}
