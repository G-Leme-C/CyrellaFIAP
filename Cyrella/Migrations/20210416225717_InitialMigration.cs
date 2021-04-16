using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cyrella.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendamentoManutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtAberturaChamado = table.Column<DateTime>(nullable: false),
                    DtAgendamento = table.Column<DateTime>(nullable: false),
                    ItemComDefeito = table.Column<string>(nullable: true),
                    DescricaoDefeito = table.Column<string>(nullable: true),
                    Comodo = table.Column<string>(nullable: true),
                    AreaDeAssistencia = table.Column<int>(nullable: false),
                    Recorrencia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendamentoManutencao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagensAgendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URL = table.Column<string>(nullable: true),
                    AgendamentoManutencaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagensAgendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagensAgendamentos_AgendamentoManutencao_AgendamentoManutencaoId",
                        column: x => x.AgendamentoManutencaoId,
                        principalTable: "AgendamentoManutencao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagensAgendamentos_AgendamentoManutencaoId",
                table: "ImagensAgendamentos",
                column: "AgendamentoManutencaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagensAgendamentos");

            migrationBuilder.DropTable(
                name: "AgendamentoManutencao");
        }
    }
}
