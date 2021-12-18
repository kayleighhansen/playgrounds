using Microsoft.EntityFrameworkCore.Migrations;

namespace playgrounds.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Date_Contact_ContactDateAddedContactId",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Date_ContactDateAddedContactId",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "ContactDateAddedContactId",
                table: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact",
                column: "DateAddedId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Date_DateAddedId",
                table: "Contact",
                column: "DateAddedId",
                principalTable: "Date",
                principalColumn: "DateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Date_DateAddedId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactDateAddedContactId",
                table: "Date",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Date_ContactDateAddedContactId",
                table: "Date",
                column: "ContactDateAddedContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Contact_ContactDateAddedContactId",
                table: "Date",
                column: "ContactDateAddedContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
