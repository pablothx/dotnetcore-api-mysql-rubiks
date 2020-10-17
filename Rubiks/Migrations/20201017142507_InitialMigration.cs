using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rubiks.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RubikCube",
                columns: table => new
                {
                    RubikId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Sides = table.Column<int>(nullable: false),
                    Complexity = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubikCube", x => x.RubikId);
                });

            migrationBuilder.CreateTable(
                name: "TrackingSolution",
                columns: table => new
                {
                    TrackingSolutionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RubikId = table.Column<int>(nullable: true),
                    ResolutionDate = table.Column<DateTime>(nullable: false),
                    ResolutionFinishedSeconds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingSolution", x => x.TrackingSolutionId);
                    table.ForeignKey(
                        name: "FK_TrackingSolution_RubikCube_RubikId",
                        column: x => x.RubikId,
                        principalTable: "RubikCube",
                        principalColumn: "RubikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackingSolution_RubikId",
                table: "TrackingSolution",
                column: "RubikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackingSolution");

            migrationBuilder.DropTable(
                name: "RubikCube");
        }
    }
}
