using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class updatedAplikimiModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fakulteti",
                table: "Aplikimet");

            migrationBuilder.AddColumn<int>(
                name: "FakultetiId",
                table: "Aplikimet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FakultetiId",
                table: "Aplikimet");

            migrationBuilder.AddColumn<string>(
                name: "Fakulteti",
                table: "Aplikimet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
