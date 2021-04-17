using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cyrella.Migrations
{
    public partial class AddTableEmpreendimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empreendimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PercentualCompleto = table.Column<int>(nullable: false),
                    FaseAtual = table.Column<string>(nullable: true),
                    DtLancamento = table.Column<DateTime>(nullable: false),
                    QtUnidadesDisponiveis = table.Column<int>(nullable: false),
                    ValorInicial = table.Column<double>(nullable: false),
                    DtInicioVistoria = table.Column<DateTime>(nullable: false),
                    DtAssembleia = table.Column<DateTime>(nullable: false),
                    PautaAssembleia = table.Column<string>(nullable: true),
                    DtEntregaChaves = table.Column<DateTime>(nullable: false),
                    DtDuracaoGarantia = table.Column<DateTime>(nullable: false),
                    CoberturaGarantia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empreendimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Afetacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bem = table.Column<string>(nullable: true),
                    ValorBem = table.Column<double>(nullable: false),
                    EmpreendimentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afetacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afetacoes_Empreendimentos_EmpreendimentoId",
                        column: x => x.EmpreendimentoId,
                        principalTable: "Empreendimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FasesObra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fase = table.Column<string>(nullable: true),
                    Percentual = table.Column<int>(nullable: false),
                    EmpreendimentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FasesObra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FasesObra_Empreendimentos_EmpreendimentoId",
                        column: x => x.EmpreendimentoId,
                        principalTable: "Empreendimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItensPersonalizacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Item = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    EmpreendimentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensPersonalizacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensPersonalizacao_Empreendimentos_EmpreendimentoId",
                        column: x => x.EmpreendimentoId,
                        principalTable: "Empreendimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afetacoes_EmpreendimentoId",
                table: "Afetacoes",
                column: "EmpreendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_FasesObra_EmpreendimentoId",
                table: "FasesObra",
                column: "EmpreendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPersonalizacao_EmpreendimentoId",
                table: "ItensPersonalizacao",
                column: "EmpreendimentoId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afetacoes");

            migrationBuilder.DropTable(
                name: "FasesObra");

            migrationBuilder.DropTable(
                name: "ItensPersonalizacao");

            migrationBuilder.DropTable(
                name: "Empreendimentos");
        }
    }
}
