using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolSaison2019.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Participants",
                table: "Participants");

            migrationBuilder.RenameTable(
                name: "Participants",
                newName: "Participant");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Participant",
                table: "Participant",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Participant",
                table: "Participant");

            migrationBuilder.RenameTable(
                name: "Participant",
                newName: "Participants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Participants",
                table: "Participants",
                column: "Id");
        }
    }
}
