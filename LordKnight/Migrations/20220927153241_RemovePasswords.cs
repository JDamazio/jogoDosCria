using Microsoft.EntityFrameworkCore.Migrations;

namespace LordKnight.Migrations
{
    public partial class RemovePasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuario",
                type: "TEXT",
                nullable: true);
        }
    }
}
