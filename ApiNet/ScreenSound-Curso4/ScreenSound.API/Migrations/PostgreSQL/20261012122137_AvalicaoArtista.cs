using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.API.Migrations.PostgreSQL
{
    /// <inheritdoc />
    public partial class AvalicaoArtista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvaliacoesArtistas",
                columns: table => new
                {
                    ArtistaId = table.Column<int>(type: "integer", nullable: false),
                    PessoaId = table.Column<int>(type: "integer", nullable: false),
                    Nota = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesArtistas", x => new { x.ArtistaId, x.PessoaId });
                    table.ForeignKey(
                        name: "FK_AvaliacoesArtistas_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacoesArtistas");
        }
    }
}
