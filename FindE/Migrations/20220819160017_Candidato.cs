using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindE.Migrations
{
    public partial class Candidato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstagiarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataDaCandidatura = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    FormacaoAcademica = table.Column<string>(type: "TEXT", nullable: true),
                    StatusFomacao = table.Column<int>(type: "INTEGER", nullable: false),
                    DataDaFormacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioGitHub = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioInstagram = table.Column<string>(type: "TEXT", nullable: true),
                    Anexo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidato_Estagiario_EstagiarioId",
                        column: x => x.EstagiarioId,
                        principalTable: "Estagiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_EstagiarioId",
                table: "Candidato",
                column: "EstagiarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato");
        }
    }
}
