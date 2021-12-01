﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WidraSoftCloud.UI.Data;

namespace WidraSoftCloud.UI.Migrations
{
    [DbContext(typeof(WidraSoftCloudUIContext))]
    partial class WidraSoftCloudUIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WidraSoftCloud.UI.Models.L", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodeA")
                        .HasColumnType("int");

                    b.Property<string>("Etat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I1")
                        .HasColumnType("int");

                    b.Property<int>("I2")
                        .HasColumnType("int");

                    b.Property<int>("I3")
                        .HasColumnType("int");

                    b.Property<int>("I4")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("L");
                });

            modelBuilder.Entity("WidraSoftCloud.UI.Models.Parametre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Param1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Param8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParamInt1")
                        .HasColumnType("int");

                    b.Property<int>("ParamInt2")
                        .HasColumnType("int");

                    b.Property<int>("ParamInt3")
                        .HasColumnType("int");

                    b.Property<string>("TypeParametre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parametre");
                });

            modelBuilder.Entity("WidraSoftCloud.UI.Models.Pesage", b =>
                {
                    b.Property<string>("UniqueKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgentPesee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CamionId")
                        .HasColumnType("int");

                    b.Property<string>("CategorieCam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientFourniId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateArrivee")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSynchronisation")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestiprovenId")
                        .HasColumnType("int");

                    b.Property<string>("Flux")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LibelleCamion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleDestination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibellePont")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleProvenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleTransporteur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoidsNet")
                        .HasColumnType("int");

                    b.Property<int>("PontId")
                        .HasColumnType("int");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("ProvenanceId")
                        .HasColumnType("int");

                    b.Property<string>("SyncId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransporteurId")
                        .HasColumnType("int");

                    b.HasKey("UniqueKey");

                    b.ToTable("Pesage");
                });

            modelBuilder.Entity("WidraSoftCloud.UI.Models.PesageControle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategorieCam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateSynchronisation")
                        .HasColumnType("datetime2");

                    b.Property<int>("PesageId")
                        .HasColumnType("int");

                    b.Property<int>("Poids1")
                        .HasColumnType("int");

                    b.Property<int>("Poids2")
                        .HasColumnType("int");

                    b.Property<int>("Poids3")
                        .HasColumnType("int");

                    b.Property<int>("PoidsTotalMaxAut")
                        .HasColumnType("int");

                    b.Property<string>("Rang1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rang2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rang3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyncId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PesageControle");
                });

            modelBuilder.Entity("WidraSoftCloud.UI.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEntree")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur");
                });
#pragma warning restore 612, 618
        }
    }
}
