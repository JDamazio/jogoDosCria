using Microsoft.EntityFrameworkCore.Migrations;

namespace LordKnight.Migrations
{
    public partial class AddCpf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Usuario");
        }
    }
}
