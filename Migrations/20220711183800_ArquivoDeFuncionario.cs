using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smk_travel.Migrations
{
    public partial class ArquivoDeFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "arquivoDeFuncionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arquivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    funcionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arquivoDeFuncionarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_arquivoDeFuncionarios_funcionarios_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_arquivoDeFuncionarios_funcionarioId",
                table: "arquivoDeFuncionarios",
                column: "funcionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "arquivoDeFuncionarios");
        }
    }
}
