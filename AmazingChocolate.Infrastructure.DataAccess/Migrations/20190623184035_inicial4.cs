using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazingChocolate.Infrastructure.DataAccess.Migrations
{
    public partial class inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pedidos_Id",
                table: "Clientes");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pedidos");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pedidos_Id",
                table: "Clientes",
                column: "Id",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
