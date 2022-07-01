using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindE.Migrations
{
    public partial class Estagiario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estagiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    WhatsApp = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Curso = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estagiario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estagiario");
        }
    }
}
