using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazingChocolate.Infrastructure.DataAccess.Migrations
{
    public partial class inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Clientes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
