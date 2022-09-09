using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class Remorques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LibelleRemorque",
                table: "Pesage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemorqueId",
                table: "Pesage",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LibelleRemorque",
                table: "Pesage");

            migrationBuilder.DropColumn(
                name: "RemorqueId",
                table: "Pesage");
        }
    }
}
