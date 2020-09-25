using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballLeague.Data.Migrations
{
    public partial class teamsAndMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamHostid = table.Column<int>(nullable: true),
                    TeamGuestid = table.Column<int>(nullable: true),
                    HostScore = table.Column<int>(nullable: false),
                    GuestScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.id);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamGuestid",
                        column: x => x.TeamGuestid,
                        principalTable: "Teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamHostid",
                        column: x => x.TeamHostid,
                        principalTable: "Teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamGuestid",
                table: "Matches",
                column: "TeamGuestid");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamHostid",
                table: "Matches",
                column: "TeamHostid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
