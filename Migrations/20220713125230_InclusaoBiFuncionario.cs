using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smk_travel.Migrations
{
    public partial class InclusaoBiFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bi",
                table: "funcionarios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bi",
                table: "funcionarios");
        }
    }
}
