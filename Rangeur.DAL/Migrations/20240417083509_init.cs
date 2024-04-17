using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    IdBonusMalus = table.Column<int>(type: "int", nullable: false),
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
                    IdLevelRangeur = table.Column<int>(type: "int", nullable: false),
                    NomLevelRangeur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleRangeurs", x => x.IdLevelRangeur);
                });

            migrationBuilder.CreateTable(
                name: "Taches",
                columns: table => new
                {
                    IdTache = table.Column<int>(type: "int", nullable: false),
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
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    PseudoUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDerniereConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    LevelRangeurIdLevelRangeur = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_RoleRangeurs_LevelRangeurIdLevelRangeur",
                        column: x => x.LevelRangeurIdLevelRangeur,
                        principalTable: "RoleRangeurs",
                        principalColumn: "IdLevelRangeur");
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    IdMission = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.InsertData(
                table: "BonusMalus",
                columns: new[] { "IdBonusMalus", "DescriptionAttribute", "NomBonusMalus", "PointBonusMalus" },
                values: new object[,]
                {
                    { 1, "Augmente votre résistance contre les obstacles et vous octroie un bonus de points.", "Potion de Résistance", 10 },
                    { 2, "Une malédiction qui vous fait perdre des points chaque jour jusqu'à ce que vous accomplissiez une tâche.", "Malédiction de l'Oubli", -5 },
                    { 3, "Un élixir mystérieux qui renforce vos capacités et double votre score actuel.", "Élixir de Puissance", 20 },
                    { 4, "Un fléau qui vous frappe lorsque vous abandonnez une tâche, vous faisant perdre des points.", "Fléau de l'Abandon", -15 }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "IdMission", "BonusMalusIdBonusMalus", "BonusMission", "DescriptionMission", "MissionDate", "NomMission", "TacheIdTache" },
                values: new object[,]
                {
                    { 1, null, 0, "Sauver une tâche en détresse avant que le soleil ne se couche.", null, "Défi du justicier quotidien", null },
                    { 2, null, 0, "Réussir au moins 5 taches héroïques dans les 24 dernières heures.", null, "Exploits de la productivité éclair", null },
                    { 3, null, 0, "Créer une toute nouvelle mission avec une description aussi unique que le pouvoir d'un super-héros.", null, "Mission de créativité cosmique", null },
                    { 4, null, 0, "Unir vos forces avec au moins 2 autres héros pour accomplir une mission digne des légendes.", null, "Légende de la collaboration suprême", null }
                });

            migrationBuilder.InsertData(
                table: "RoleRangeurs",
                columns: new[] { "IdLevelRangeur", "NomLevelRangeur" },
                values: new object[,]
                {
                    { 1, "Apprenti" },
                    { 2, "Compagnon" },
                    { 3, "Artisan" },
                    { 4, "Maître" },
                    { 5, "Grand Maître" },
                    { 6, "Architecte" },
                    { 7, "Visionnaire" },
                    { 8, "Gourou" },
                    { 9, "Virtuose" },
                    { 10, "Sage" }
                });

            migrationBuilder.InsertData(
                table: "Taches",
                columns: new[] { "IdTache", "DateCreation", "DateDebut", "DateEcheance", "DateFin", "Description", "NomTache", "PointBonusMalusIdBonusMalus", "PrioriteTaches", "Recurrence", "Statut" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3214), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Laver les vêtements", "Faire la lessive", null, 0, "Non", 0 },
                    { 2, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Nettoyer les sols avec l'aspirateur", "Passer l'aspirateur", null, 0, "Non", 0 },
                    { 3, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Nettoyer les assiettes, verres et couverts", "Laver la vaisselle", null, 0, "Non", 0 },
                    { 4, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Donner un bain au chien et le sécher", "Laver le chien", null, 0, "Non", 0 },
                    { 5, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Organiser les outils et les équipements dans le garage", "Ranger le garage", null, 0, "Non", 0 },
                    { 6, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Vider la poubelle et la mettre à l'extérieur pour la collecte des déchets", "Sortir la poubelle", null, 0, "Non", 0 },
                    { 7, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Préparer le repas du soir pour la famille", "Faire le souper", null, 0, "Non", 0 },
                    { 8, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Acheter les produits alimentaires et autres nécessités", "Faire les courses", null, 0, "Non", 0 },
                    { 9, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Faire en sorte que le chien soit aussi propre que son maître après une séance de saut dans les flaques de boue.", "Laver le chien", null, 0, "Non", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "DateDerniereConnexion", "DateNaissance", "Email", "LevelRangeurIdLevelRangeur", "Nom", "Password", "Prenom", "PseudoUser", "Role", "Score", "Telephone" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2725), new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ariana.grande@example.com", null, "Grande", "password123", "Ariana", "ArianaGrande", "Standard", 100, 123456789 },
                    { 2, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2820), new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ed.sheeran@example.com", null, "Sheeran", "password456", "Ed", "EdSheeran", "Standard", 150, 987654321 },
                    { 3, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2824), new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "beyonce.knowles@example.com", null, "Knowles", "password789", "Beyoncé", "Beyonce", "Standard", 200, 555555555 },
                    { 4, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2828), new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "tom.hanks@example.com", null, "Hanks", "password123", "Tom", "TomHanks", "Standard", 100, 123456789 },
                    { 5, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2831), new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.lawrence@example.com", null, "Lawrence", "password456", "Jennifer", "JenniferLawrence", "Standard", 150, 987654321 },
                    { 6, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2834), new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "leonardo.dicaprio@example.com", null, "DiCaprio", "password789", "Leonardo", "LeonardoDiCaprio", "Standard", 200, 555555555 },
                    { 7, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2838), new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "brad.pitt@example.com", null, "Pitt", "password123", "Brad", "BradPitt", "Standard", 180, 111222333 },
                    { 8, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2846), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "scarlett.johansson@example.com", null, "Johansson", "password456", "Scarlett", "ScarlettJohansson", "Standard", 220, 444555666 },
                    { 9, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2849), new DateTime(1954, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "denzel.washington@example.com", null, "Washington", "password789", "Denzel", "DenzelWashington", "Standard", 250, 777888999 },
                    { 10, new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2853), new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucietonelli@gmail.com", null, "Tonelli", "password123", "Lucie", "Lucie", "Admin", 250, 777888999 }
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
                name: "IX_Users_LevelRangeurIdLevelRangeur",
                table: "Users",
                column: "LevelRangeurIdLevelRangeur");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PseudoUser",
                table: "Users",
                column: "PseudoUser",
                unique: true);
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
