using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class updateF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUploaded",
                table: "FileDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "FileDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "FileDetails",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUploaded",
                table: "FileDetails");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "FileDetails");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "FileDetails");
        }
    }
}
