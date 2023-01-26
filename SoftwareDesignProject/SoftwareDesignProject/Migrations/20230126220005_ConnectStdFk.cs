﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    /// <inheritdoc />
    public partial class ConnectStdFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FakultetiId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_FakultetiId",
                table: "Students",
                column: "FakultetiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Fakultetet_FakultetiId",
                table: "Students",
                column: "FakultetiId",
                principalTable: "Fakultetet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}