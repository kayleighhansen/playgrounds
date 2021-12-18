using Microsoft.EntityFrameworkCore.Migrations;

namespace playgrounds.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactDateAddedId",
                table: "Date",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact",
                column: "DateAddedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactDateAddedId",
                table: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DateAddedId",
                table: "Contact",
                column: "DateAddedId",
                unique: true);
        }
    }
}
