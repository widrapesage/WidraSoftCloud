using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class remove_Rang4_Poids4_PesageControle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poids4",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Rang4",
                table: "PesageControle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
