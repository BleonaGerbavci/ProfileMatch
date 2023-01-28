using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    /// <inheritdoc />
    public partial class FileUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "canApply",
                table: "Aplikimet");

            migrationBuilder.RenameColumn(
                name: "OpenDate",
                table: "Aplikimet",
                newName: "OpenedDate");

            migrationBuilder.RenameColumn(
                name: "CloseDate",
                table: "Aplikimet",
                newName: "ClosedDate");

            migrationBuilder.CreateTable(
                name: "FileDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetails", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileDetails");

            migrationBuilder.RenameColumn(
                name: "OpenedDate",
                table: "Aplikimet",
                newName: "OpenDate");

            migrationBuilder.RenameColumn(
                name: "ClosedDate",
                table: "Aplikimet",
                newName: "CloseDate");

            migrationBuilder.AddColumn<bool>(
                name: "canApply",
                table: "Aplikimet",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
