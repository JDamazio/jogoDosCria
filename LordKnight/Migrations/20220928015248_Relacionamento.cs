using Microsoft.EntityFrameworkCore.Migrations;

namespace LordKnight.Migrations
{
    public partial class Relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Personagens",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Personagens",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_NivelId",
                table: "Personagens",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UserId",
                table: "Personagens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Nivel_NivelId",
                table: "Personagens",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuario_UserId",
                table: "Personagens",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Nivel_NivelId",
                table: "Personagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuario_UserId",
                table: "Personagens");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_NivelId",
                table: "Personagens");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UserId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Personagens");
        }
    }
}
