using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class _4eme_groupe_essieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Max4",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Poids4",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rang4",
                table: "PesageControle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Surcharge4",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Max4",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Poids4",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Rang4",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Surcharge4",
                table: "PesageControle");
        }
    }
}
