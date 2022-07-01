using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindE.Migrations
{
    public partial class RemocaoDoCampoFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoEmpresa",
                table: "Empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoEmpresa",
                table: "Empresa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
