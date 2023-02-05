using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class PMUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileMatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsForGPA = table.Column<int>(type: "int", nullable: false),
                    PointsForCity = table.Column<int>(type: "int", nullable: false),
                    ExtraPoints = table.Column<int>(type: "int", nullable: false),
                    TotalPoints = table.Column<int>(type: "int", nullable: false),
                    AplikimiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileMatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileMatch_Aplikimet_AplikimiId",
                        column: x => x.AplikimiId,
                        principalTable: "Aplikimet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileMatch_AplikimiId",
                table: "ProfileMatch",
                column: "AplikimiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileMatch");
        }
    }
}
