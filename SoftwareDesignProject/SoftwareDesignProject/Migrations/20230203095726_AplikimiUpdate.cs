using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class AplikimiUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Aplikimet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Aplikimet_FileId",
                table: "Aplikimet",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet",
                column: "FileId",
                principalTable: "FileDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet");

            migrationBuilder.DropIndex(
                name: "IX_Aplikimet_FileId",
                table: "Aplikimet");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Aplikimet");
        }
    }
}
