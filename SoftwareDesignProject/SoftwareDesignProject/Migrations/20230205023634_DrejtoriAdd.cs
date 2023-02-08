using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class DrejtoriAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drejtoret",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendlindja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumriTelefonit = table.Column<int>(type: "int", nullable: false),
                    AnkesaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drejtoret", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drejtoret_Ankesat_AnkesaId",
                        column: x => x.AnkesaId,
                        principalTable: "Ankesat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drejtoret_AnkesaId",
                table: "Drejtoret",
                column: "AnkesaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drejtoret");
        }
    }
}
