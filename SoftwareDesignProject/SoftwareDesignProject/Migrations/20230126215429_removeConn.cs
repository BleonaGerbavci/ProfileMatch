using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    /// <inheritdoc />
    public partial class removeConn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Fakultetet_FakultetiId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FakultetiId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FakultetiId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentPersonalNumber",
                table: "Fakultetet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FakultetiId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentPersonalNumber",
                table: "Fakultetet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_FakultetiId",
                table: "Students",
                column: "FakultetiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Fakultetet_FakultetiId",
                table: "Students",
                column: "FakultetiId",
                principalTable: "Fakultetet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
