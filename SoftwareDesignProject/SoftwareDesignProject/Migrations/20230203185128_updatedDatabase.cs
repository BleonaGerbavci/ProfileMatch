using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class updatedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");

            migrationBuilder.DropIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");

            migrationBuilder.DropColumn(
                name: "ListaEAplikanteveNumriRendor",
                table: "ProfileMatch");

            migrationBuilder.AddColumn<int>(
                name: "ListaEAplikanteveId",
                table: "ProfileMatch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ListaEAplikanteve",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.DropIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.DropColumn(
                name: "ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ListaEAplikanteve");

            migrationBuilder.AddColumn<int>(
                name: "ListaEAplikanteveNumriRendor",
                table: "ProfileMatch",
                type: "int",
                nullable: true);

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
    }
}
