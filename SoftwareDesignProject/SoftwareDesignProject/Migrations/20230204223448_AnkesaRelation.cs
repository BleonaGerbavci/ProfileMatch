using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class AnkesaRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumriPersonal",
                table: "Ankesat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentiNrLeternjoftimit",
                table: "Ankesat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ankesat_StudentiNrLeternjoftimit",
                table: "Ankesat",
                column: "StudentiNrLeternjoftimit");

            migrationBuilder.AddForeignKey(
                name: "FK_Ankesat_Students_StudentiNrLeternjoftimit",
                table: "Ankesat",
                column: "StudentiNrLeternjoftimit",
                principalTable: "Students",
                principalColumn: "NrLeternjoftimit",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ankesat_Students_StudentiNrLeternjoftimit",
                table: "Ankesat");

            migrationBuilder.DropIndex(
                name: "IX_Ankesat_StudentiNrLeternjoftimit",
                table: "Ankesat");

            migrationBuilder.DropColumn(
                name: "NumriPersonal",
                table: "Ankesat");

            migrationBuilder.DropColumn(
                name: "StudentiNrLeternjoftimit",
                table: "Ankesat");
        }
    }
}
