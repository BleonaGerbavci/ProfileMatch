using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class UpdatedAplikimi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedDate",
                table: "Aplikimet");

            migrationBuilder.DropColumn(
                name: "OpenedDate",
                table: "Aplikimet");

            migrationBuilder.RenameColumn(
                name: "ApplicationStatus",
                table: "Aplikimet",
                newName: "Fakulteti");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fakulteti",
                table: "Aplikimet",
                newName: "ApplicationStatus");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedDate",
                table: "Aplikimet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpenedDate",
                table: "Aplikimet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
