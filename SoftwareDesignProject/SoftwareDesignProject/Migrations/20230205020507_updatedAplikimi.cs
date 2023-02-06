using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class updatedAplikimi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Aplikimet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet",
                column: "FileId",
                principalTable: "FileDetails",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Aplikimet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet",
                column: "FileId",
                principalTable: "FileDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
