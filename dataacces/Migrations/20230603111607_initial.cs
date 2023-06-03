using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataacces.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deaddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorIds = table.Column<int>(type: "int", nullable: false),
                    Actorsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_films_actors_Actorsid",
                        column: x => x.Actorsid,
                        principalTable: "actors",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "seans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmid = table.Column<int>(type: "int", nullable: false),
                    timestart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    timeend = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seans_films_filmid",
                        column: x => x.filmid,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_films_Actorsid",
                table: "films",
                column: "Actorsid");

            migrationBuilder.CreateIndex(
                name: "IX_seans_filmid",
                table: "seans",
                column: "filmid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seans");

            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "actors");
        }
    }
}
