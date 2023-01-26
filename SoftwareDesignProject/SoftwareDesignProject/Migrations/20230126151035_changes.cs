using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakultetet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drejtimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departamenti = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultetet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    NrLeternjoftimit = table.Column<int>(type: "int", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmriIPrindit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qyteti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotaMesatare = table.Column<float>(type: "real", nullable: false),
                    NumriKontaktues = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gjinia = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    VitiIStudimeve = table.Column<int>(type: "int", nullable: false),
                    Statusi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FakultetiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.NrLeternjoftimit);
                    table.ForeignKey(
                        name: "FK_Students_Fakultetet_FakultetiId",
                        column: x => x.FakultetiId,
                        principalTable: "Fakultetet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FakultetiId",
                table: "Students",
                column: "FakultetiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Fakultetet");
        }
    }
}
