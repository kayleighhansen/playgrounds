using Microsoft.EntityFrameworkCore.Migrations;

namespace playgrounds.Migrations
{
    public partial class TestingSomeMore3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DateAddedId",
                table: "Note",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Note_DateAddedId",
                table: "Note",
                column: "DateAddedId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Date_DateAddedId",
                table: "Note",
                column: "DateAddedId",
                principalTable: "Date",
                principalColumn: "DateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Date_DateAddedId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_DateAddedId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "DateAddedId",
                table: "Note");
        }
    }
}
