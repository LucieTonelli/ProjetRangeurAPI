using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rangeur.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BonusMalus",
                columns: table => new
                {
                    IdBonusMalus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomBonusMalus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionAttribute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointBonusMalus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusMalus", x => x.IdBonusMalus);
                });

            migrationBuilder.CreateTable(
                name: "RoleRangeurs",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleRangeurs", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Taches",
                columns: table => new
                {
                    IdTache = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomTache = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    PrioriteTaches = table.Column<int>(type: "int", nullable: false),
                    Recurrence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEcheance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PointBonusMalusIdBonusMalus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taches", x => x.IdTache);
                    table.ForeignKey(
                        name: "FK_Taches_BonusMalus_PointBonusMalusIdBonusMalus",
                        column: x => x.PointBonusMalusIdBonusMalus,
                        principalTable: "BonusMalus",
                        principalColumn: "IdBonusMalus");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PseudoUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDerniereConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    RoleRangeurIdRole = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_RoleRangeurs_RoleRangeurIdRole",
                        column: x => x.RoleRangeurIdRole,
                        principalTable: "RoleRangeurs",
                        principalColumn: "IdRole");
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    IdMission = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionMission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BonusMission = table.Column<int>(type: "int", nullable: false),
                    BonusMalusIdBonusMalus = table.Column<int>(type: "int", nullable: true),
                    TacheIdTache = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.IdMission);
                    table.ForeignKey(
                        name: "FK_Missions_BonusMalus_BonusMalusIdBonusMalus",
                        column: x => x.BonusMalusIdBonusMalus,
                        principalTable: "BonusMalus",
                        principalColumn: "IdBonusMalus");
                    table.ForeignKey(
                        name: "FK_Missions_Taches_TacheIdTache",
                        column: x => x.TacheIdTache,
                        principalTable: "Taches",
                        principalColumn: "IdTache");
                });

            migrationBuilder.CreateTable(
                name: "TacheUser",
                columns: table => new
                {
                    TachesIdTache = table.Column<int>(type: "int", nullable: false),
                    UsersIdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacheUser", x => new { x.TachesIdTache, x.UsersIdUser });
                    table.ForeignKey(
                        name: "FK_TacheUser_Taches_TachesIdTache",
                        column: x => x.TachesIdTache,
                        principalTable: "Taches",
                        principalColumn: "IdTache",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TacheUser_Users_UsersIdUser",
                        column: x => x.UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissionUser",
                columns: table => new
                {
                    MissionsIdMission = table.Column<int>(type: "int", nullable: false),
                    UsersIdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionUser", x => new { x.MissionsIdMission, x.UsersIdUser });
                    table.ForeignKey(
                        name: "FK_MissionUser_Missions_MissionsIdMission",
                        column: x => x.MissionsIdMission,
                        principalTable: "Missions",
                        principalColumn: "IdMission",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionUser_Users_UsersIdUser",
                        column: x => x.UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_BonusMalusIdBonusMalus",
                table: "Missions",
                column: "BonusMalusIdBonusMalus");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_TacheIdTache",
                table: "Missions",
                column: "TacheIdTache");

            migrationBuilder.CreateIndex(
                name: "IX_MissionUser_UsersIdUser",
                table: "MissionUser",
                column: "UsersIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Taches_PointBonusMalusIdBonusMalus",
                table: "Taches",
                column: "PointBonusMalusIdBonusMalus");

            migrationBuilder.CreateIndex(
                name: "IX_TacheUser_UsersIdUser",
                table: "TacheUser",
                column: "UsersIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleRangeurIdRole",
                table: "Users",
                column: "RoleRangeurIdRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissionUser");

            migrationBuilder.DropTable(
                name: "TacheUser");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Taches");

            migrationBuilder.DropTable(
                name: "RoleRangeurs");

            migrationBuilder.DropTable(
                name: "BonusMalus");
        }
    }
}
