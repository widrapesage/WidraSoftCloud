using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class licence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "L",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeA = table.Column<int>(type: "int", nullable: false),
                    I1 = table.Column<int>(type: "int", nullable: false),
                    I2 = table.Column<int>(type: "int", nullable: false),
                    I3 = table.Column<int>(type: "int", nullable: false),
                    I4 = table.Column<int>(type: "int", nullable: false),
                    Etat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeParametre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParamInt1 = table.Column<int>(type: "int", nullable: false),
                    ParamInt2 = table.Column<int>(type: "int", nullable: false),
                    ParamInt3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametre", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L");

            migrationBuilder.DropTable(
                name: "Parametre");
        }
    }
}
