using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    public partial class DbChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet");

            migrationBuilder.DropForeignKey(
                name: "FK_Drejtoret_Ankesat_AnkesaId",
                table: "Drejtoret");

            migrationBuilder.DropIndex(
                name: "IX_Drejtoret_AnkesaId",
                table: "Drejtoret");

            migrationBuilder.DropColumn(
                name: "AnkesaId",
                table: "Drejtoret");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Aplikimet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "Aplikimet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Aplikimet");

            migrationBuilder.AddColumn<int>(
                name: "AnkesaId",
                table: "Drejtoret",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Aplikimet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drejtoret_AnkesaId",
                table: "Drejtoret",
                column: "AnkesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aplikimet_FileDetails_FileId",
                table: "Aplikimet",
                column: "FileId",
                principalTable: "FileDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drejtoret_Ankesat_AnkesaId",
                table: "Drejtoret",
                column: "AnkesaId",
                principalTable: "Ankesat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
