using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolSaison2019.Migrations
{
    public partial class changementParticipant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastWeekRank",
                table: "Participant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rang",
                table: "Participant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastWeekRank",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Rang",
                table: "Participant");
        }
    }
}
