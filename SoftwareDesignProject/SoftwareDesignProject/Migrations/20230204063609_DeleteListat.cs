using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class DeleteListat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.DropTable(
                name: "ListaEAplikanteve");

            migrationBuilder.DropIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.DropColumn(
                name: "ListaEAplikanteveId",
                table: "ProfileMatch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListaEAplikanteveId",
                table: "ProfileMatch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ListaEAplikanteve",
                columns: table => new
                {
                    NumriRendor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalApplicants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaEAplikanteve", x => x.NumriRendor);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveId",
                table: "ProfileMatch",
                column: "ListaEAplikanteveId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveId",
                table: "ProfileMatch",
                column: "ListaEAplikanteveId",
                principalTable: "ListaEAplikanteve",
                principalColumn: "NumriRendor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
