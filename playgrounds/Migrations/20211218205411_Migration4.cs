using Microsoft.EntityFrameworkCore.Migrations;

namespace playgrounds.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Date_Note_NoteDateAddedNoteId",
                table: "Date");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Date_NoteDateAddedNoteId",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "NoteDateAddedNoteId",
                table: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoteDateAddedNoteId",
                table: "Date",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NoteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Date_NoteDateAddedNoteId",
                table: "Date",
                column: "NoteDateAddedNoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Note_NoteDateAddedNoteId",
                table: "Date",
                column: "NoteDateAddedNoteId",
                principalTable: "Note",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
