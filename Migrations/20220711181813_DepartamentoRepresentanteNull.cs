using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smk_travel.Migrations
{
    public partial class DepartamentoRepresentanteNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "funcionarioRepresentanteId",
                table: "departamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "SituacaoViagens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViagemId = table.Column<int>(type: "int", nullable: false),
                    situacao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoViagens", x => x.id);
                    table.ForeignKey(
                        name: "FK_SituacaoViagens_viagens_ViagemId",
                        column: x => x.ViagemId,
                        principalTable: "viagens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SituacaoViagens_ViagemId",
                table: "SituacaoViagens",
                column: "ViagemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SituacaoViagens");

            migrationBuilder.AlterColumn<int>(
                name: "funcionarioRepresentanteId",
                table: "departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
