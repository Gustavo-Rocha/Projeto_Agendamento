using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agendamento.Migrations
{
    public partial class ModelV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Data);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(maxLength: 9, nullable: true),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Cep = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cpf);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
