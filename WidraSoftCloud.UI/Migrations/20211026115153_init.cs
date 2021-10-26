using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WidraSoftCloud.UI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pesage",
                columns: table => new
                {
                    UniqueKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PontId = table.Column<int>(type: "int", nullable: false),
                    LibellePont = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamionId = table.Column<int>(type: "int", nullable: false),
                    LibelleCamion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flux = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransporteurId = table.Column<int>(type: "int", nullable: false),
                    LibelleTransporteur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    LibelleProduit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestiprovenId = table.Column<int>(type: "int", nullable: false),
                    LibelleDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientFourniId = table.Column<int>(type: "int", nullable: false),
                    LibelleClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategorieCam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateArrivee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoidsNet = table.Column<int>(type: "int", nullable: false),
                    AgentPesee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvenanceId = table.Column<int>(type: "int", nullable: false),
                    LibelleProvenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSynchronisation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesage", x => x.UniqueKey);
                });

            migrationBuilder.CreateTable(
                name: "PesageControle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PesageId = table.Column<int>(type: "int", nullable: false),
                    UniqueKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategorieCam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoidsTotalMaxAut = table.Column<int>(type: "int", nullable: false),
                    Rang1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poids1 = table.Column<int>(type: "int", nullable: false),
                    Rang2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poids2 = table.Column<int>(type: "int", nullable: false),
                    Rang3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poids3 = table.Column<int>(type: "int", nullable: false),
                    Rang4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poids4 = table.Column<int>(type: "int", nullable: false),
                    DateSynchronisation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesageControle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEntree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesage");

            migrationBuilder.DropTable(
                name: "PesageControle");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
