using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agenda.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tabelaTarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Listas_Tarefas",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Tarefa_ = table.Column<int>(type: "int", nullable: false),
                    Lista_TarefasID = table.Column<int>(type: "int", nullable: false),
                    Defenição = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prazo = table.Column<int>(type: "int", nullable: false),
                    Prioridade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Tarefa_);
                    table.ForeignKey(
                        name: "FK_Tarefas_Listas_Tarefas_Lista_TarefasID",
                        column: x => x.Lista_TarefasID,
                        principalTable: "Listas_Tarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_Lista_TarefasID",
                table: "Tarefas",
                column: "Lista_TarefasID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Listas_Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }
    }
}
