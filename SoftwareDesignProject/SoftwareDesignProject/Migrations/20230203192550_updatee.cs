﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class updatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveId",
                table: "ProfileMatch");

            migrationBuilder.RenameColumn(
                name: "ListaEAplikanteveId",
                table: "ProfileMatch",
                newName: "ListaId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfileMatch_ListaEAplikanteveId",
                table: "ProfileMatch",
                newName: "IX_ProfileMatch_ListaId");

            migrationBuilder.RenameColumn(
                name: "NumriRendor",
                table: "ListaEAplikanteve",
                newName: "ListaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaId",
                table: "ProfileMatch",
                column: "ListaId",
                principalTable: "ListaEAplikanteve",
                principalColumn: "ListaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaId",
                table: "ProfileMatch");

            migrationBuilder.RenameColumn(
                name: "ListaId",
                table: "ProfileMatch",
                newName: "ListaEAplikanteveId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfileMatch_ListaId",
                table: "ProfileMatch",
                newName: "IX_ProfileMatch_ListaEAplikanteveId");

            migrationBuilder.RenameColumn(
                name: "ListaId",
                table: "ListaEAplikanteve",
                newName: "NumriRendor");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMatch_ListaEAplikanteve_ListaEAplikanteveId",
                table: "ProfileMatch",
                column: "ListaEAplikanteveId",
                principalTable: "ListaEAplikanteve",
                principalColumn: "NumriRendor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}