using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class UpdateAplikimi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FakultetiId",
                table: "Aplikimet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FakultetiId",
                table: "Aplikimet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
