using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class UpdateLista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListaEAplikanteveNumriRendor",
                table: "ProfileMatch",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListaEAplikanteve",
                columns: table => new
                {
                    NumriRendor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalApplicants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaEAplikanteve", x => x.NumriRendor);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch",
                column: "ListaEAplikanteveNumriRendor");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch",
                column: "ListaEAplikanteveNumriRendor",
                principalTable: "ListaEAplikanteve",
                principalColumn: "NumriRendor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");

            migrationBuilder.DropTable(
                name: "ListaEAplikanteve");

            migrationBuilder.DropIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");

            migrationBuilder.DropColumn(
                name: "ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");
        }
    }
}
