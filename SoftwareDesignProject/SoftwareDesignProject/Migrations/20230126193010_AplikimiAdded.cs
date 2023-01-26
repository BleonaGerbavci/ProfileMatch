using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    /// <inheritdoc />
    public partial class AplikimiAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aplikimet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(type: "int", nullable: false),
                    Fakulteti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canApply = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isSpecialCategory = table.Column<bool>(type: "bit", nullable: false),
                    SpecialCategoryReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentiNrLeternjoftimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplikimet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aplikimet_Students_StudentiNrLeternjoftimit",
                        column: x => x.StudentiNrLeternjoftimit,
                        principalTable: "Students",
                        principalColumn: "NrLeternjoftimit",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aplikimet_StudentiNrLeternjoftimit",
                table: "Aplikimet",
                column: "StudentiNrLeternjoftimit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aplikimet");
        }
    }
}
