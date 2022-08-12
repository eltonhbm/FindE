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
                    IdEstagiario = table.Column<int>(type: "INTEGER", nullable: false),
                    EstagiarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataDaCandidatura = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    FormacaoAcademica = table.Column<string>(type: "TEXT", nullable: false),
                    StatusFomacao = table.Column<int>(type: "INTEGER", nullable: false),
                    DataDaFormacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioGitHub = table.Column<string>(type: "TEXT", nullable: false),
                    UsuarioInstagram = table.Column<string>(type: "TEXT", nullable: false),
                    Whatsapp = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CandidatoAnexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    CandidatoModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoAnexo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidatoAnexo_Candidato_CandidatoModelId",
                        column: x => x.CandidatoModelId,
                        principalTable: "Candidato",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_EstagiarioId",
                table: "Candidato",
                column: "EstagiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoAnexo_CandidatoModelId",
                table: "CandidatoAnexo",
                column: "CandidatoModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoAnexo");

            migrationBuilder.DropTable(
                name: "Candidato");
        }
    }
}
