using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolSaison2019.Migrations
{
    public partial class bob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Signatures");

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
    }
}
