using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smk_travel.Migrations
{
    public partial class Migracoes20220807 : Migration
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
                name: "centroDeCustos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_centroDeCustos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "companhiaAereas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companhiaAereas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    funcionarioRepresentanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estadoDaViagens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoDaViagens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fornecedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nif = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    morada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedores", x => x.id);
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
                name: "motivos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motivos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "profissoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profissoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sites",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sites", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoDeBilhetes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDeBilhetes", x => x.id);
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
                    centroDeCustoId = table.Column<int>(type: "int", nullable: false),
                    entidadeId = table.Column<int>(type: "int", nullable: false),
                    profissaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_funcionarios_centroDeCustos_centroDeCustoId",
                        column: x => x.centroDeCustoId,
                        principalTable: "centroDeCustos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_departamentos_departamentoId",
                        column: x => x.departamentoId,
                        principalTable: "departamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_entidades_entidadeId",
                        column: x => x.entidadeId,
                        principalTable: "entidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_profissoes_profissaoId",
                        column: x => x.profissaoId,
                        principalTable: "profissoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "processos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcionarioId = table.Column<int>(type: "int", nullable: false),
                    itinerarioId = table.Column<int>(type: "int", nullable: false),
                    siteId = table.Column<int>(type: "int", nullable: false),
                    dataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataChagada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motivoId = table.Column<int>(type: "int", nullable: false),
                    testeCovid = table.Column<bool>(type: "bit", nullable: false),
                    comentarios = table.Column<string>(type: "Text", nullable: false),
                    diasDeTrabalho = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataSolicitacaoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataSolicitacaoFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processos", x => x.id);
                    table.ForeignKey(
                        name: "FK_processos_funcionarios_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_processos_itinerarios_itinerarioId",
                        column: x => x.itinerarioId,
                        principalTable: "itinerarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_processos_motivos_motivoId",
                        column: x => x.motivoId,
                        principalTable: "motivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_processos_sites_siteId",
                        column: x => x.siteId,
                        principalTable: "sites",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "viagens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroBilhete = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    funcionarioId = table.Column<int>(type: "int", nullable: false),
                    itinerarioId = table.Column<int>(type: "int", nullable: false),
                    CompanhiaAereaId = table.Column<int>(type: "int", nullable: false),
                    dataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataChagada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    alojamentoId = table.Column<int>(type: "int", nullable: false),
                    testeCovid = table.Column<bool>(type: "bit", nullable: false),
                    comentarios = table.Column<string>(type: "Text", nullable: false),
                    hospede = table.Column<bool>(type: "bit", nullable: false),
                    diasDeTrabalho = table.Column<int>(type: "int", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motivoId = table.Column<int>(type: "int", nullable: false),
                    classeId = table.Column<int>(type: "int", nullable: false),
                    tipoDeBilheteId = table.Column<int>(type: "int", nullable: false),
                    estadoDaViagemId = table.Column<int>(type: "int", nullable: false),
                    totalBilhete = table.Column<double>(type: "float", nullable: false),
                    custoBilhete = table.Column<double>(type: "float", nullable: false),
                    custoReemissao = table.Column<double>(type: "float", nullable: false),
                    taxaReembolso = table.Column<double>(type: "float", nullable: false),
                    custoNoShow = table.Column<double>(type: "float", nullable: false),
                    processoId = table.Column<int>(type: "int", nullable: false),
                    dataSolicitacaoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataSolicitacaoFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    arquivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
                        name: "FK_viagens_classes_classeId",
                        column: x => x.classeId,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_companhiaAereas_CompanhiaAereaId",
                        column: x => x.CompanhiaAereaId,
                        principalTable: "companhiaAereas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_estadoDaViagens_estadoDaViagemId",
                        column: x => x.estadoDaViagemId,
                        principalTable: "estadoDaViagens",
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
                    table.ForeignKey(
                        name: "FK_viagens_motivos_motivoId",
                        column: x => x.motivoId,
                        principalTable: "motivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viagens_processos_processoId",
                        column: x => x.processoId,
                        principalTable: "processos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_viagens_tipoDeBilhetes_tipoDeBilheteId",
                        column: x => x.tipoDeBilheteId,
                        principalTable: "tipoDeBilhetes",
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
                name: "IX_funcionarios_entidadeId",
                table: "funcionarios",
                column: "entidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_profissaoId",
                table: "funcionarios",
                column: "profissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_processos_funcionarioId",
                table: "processos",
                column: "funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_processos_itinerarioId",
                table: "processos",
                column: "itinerarioId");

            migrationBuilder.CreateIndex(
                name: "IX_processos_motivoId",
                table: "processos",
                column: "motivoId");

            migrationBuilder.CreateIndex(
                name: "IX_processos_siteId",
                table: "processos",
                column: "siteId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_alojamentoId",
                table: "viagens",
                column: "alojamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_classeId",
                table: "viagens",
                column: "classeId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_CompanhiaAereaId",
                table: "viagens",
                column: "CompanhiaAereaId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_estadoDaViagemId",
                table: "viagens",
                column: "estadoDaViagemId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_funcionarioId",
                table: "viagens",
                column: "funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_itinerarioId",
                table: "viagens",
                column: "itinerarioId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_motivoId",
                table: "viagens",
                column: "motivoId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_processoId",
                table: "viagens",
                column: "processoId");

            migrationBuilder.CreateIndex(
                name: "IX_viagens_tipoDeBilheteId",
                table: "viagens",
                column: "tipoDeBilheteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "fornecedores");

            migrationBuilder.DropTable(
                name: "viagens");

            migrationBuilder.DropTable(
                name: "alojamentos");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "companhiaAereas");

            migrationBuilder.DropTable(
                name: "estadoDaViagens");

            migrationBuilder.DropTable(
                name: "processos");

            migrationBuilder.DropTable(
                name: "tipoDeBilhetes");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "itinerarios");

            migrationBuilder.DropTable(
                name: "motivos");

            migrationBuilder.DropTable(
                name: "sites");

            migrationBuilder.DropTable(
                name: "centroDeCustos");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "entidades");

            migrationBuilder.DropTable(
                name: "profissoes");
        }
    }
}
