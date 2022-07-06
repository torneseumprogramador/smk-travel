using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smk_travel.Migrations
{
    public partial class TabelasIniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "alojamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    morada = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    responsavel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alojamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "centro_de_custos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_centro_de_custos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CompanhiaAerias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanhiaAerias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "itinerarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itinerarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    departamentoId = table.Column<int>(type: "int", nullable: false),
                    centroDeCustoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_funcionarios_centro_de_custos_centroDeCustoId",
                        column: x => x.centroDeCustoId,
                        principalTable: "centro_de_custos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_departamentos_departamentoId",
                        column: x => x.departamentoId,
                        principalTable: "departamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "viagens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcionarioId = table.Column<int>(type: "int", nullable: false),
                    itinerarioId = table.Column<int>(type: "int", nullable: false),
                    companhiaAeriaId = table.Column<int>(type: "int", nullable: false),
                    dataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataChagada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    alojamentoId = table.Column<int>(type: "int", nullable: false),
                    testeCovid = table.Column<bool>(type: "bit", nullable: false),
                    comentarios = table.Column<string>(type: "Text", nullable: false),
                    hospede = table.Column<bool>(type: "bit", nullable: false),
                    diasDeTrabalho = table.Column<int>(type: "int", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viagens", x => x.id);
                    table.ForeignKey(
                        name: "FK_viagens_alojamentos_alojamentoId",
                        column: x => x.alojamentoId,
                        principalTable: "alojamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_CompanhiaAerias_companhiaAeriaId",
                        column: x => x.companhiaAeriaId,
                        principalTable: "CompanhiaAerias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_funcionarios_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_itinerarios_itinerarioId",
                        column: x => x.itinerarioId,
                        principalTable: "itinerarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_centroDeCustoId",
                table: "funcionarios",
                column: "centroDeCustoId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_departamentoId",
                table: "funcionarios",
                column: "departamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_alojamentoId",
                table: "viagens",
                column: "alojamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_companhiaAeriaId",
                table: "viagens",
                column: "companhiaAeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_funcionarioId",
                table: "viagens",
                column: "funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_itinerarioId",
                table: "viagens",
                column: "itinerarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "viagens");

            migrationBuilder.DropTable(
                name: "alojamentos");

            migrationBuilder.DropTable(
                name: "CompanhiaAerias");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "itinerarios");

            migrationBuilder.DropTable(
                name: "centro_de_custos");

            migrationBuilder.DropTable(
                name: "departamentos");
        }
    }
}
