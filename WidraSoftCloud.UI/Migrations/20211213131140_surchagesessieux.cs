using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class surchagesessieux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Max1",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Max2",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Max3",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Surcharge1",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Surcharge2",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Surcharge3",
                table: "PesageControle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Max1",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Max2",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Max3",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Surcharge1",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Surcharge2",
                table: "PesageControle");

            migrationBuilder.DropColumn(
                name: "Surcharge3",
                table: "PesageControle");
        }
    }
}
