﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rangeur.DAL;

#nullable disable

namespace Rangeur.DAL.Migrations
{
    [DbContext(typeof(RangeurContext))]
    partial class RangeurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MissionUser", b =>
                {
                    b.Property<int>("MissionsIdMission")
                        .HasColumnType("int");

                    b.Property<int>("UsersIdUser")
                        .HasColumnType("int");

                    b.HasKey("MissionsIdMission", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("MissionUser");
                });

            modelBuilder.Entity("Rangeur.Domain.Models.BonusMalus", b =>
                {
                    b.Property<int>("IdBonusMalus")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionAttribute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomBonusMalus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointBonusMalus")
                        .HasColumnType("int");

                    b.HasKey("IdBonusMalus");

                    b.ToTable("BonusMalus");

                    b.HasData(
                        new
                        {
                            IdBonusMalus = 1,
                            DescriptionAttribute = "Augmente votre résistance contre les obstacles et vous octroie un bonus de points.",
                            NomBonusMalus = "Potion de Résistance",
                            PointBonusMalus = 10
                        },
                        new
                        {
                            IdBonusMalus = 2,
                            DescriptionAttribute = "Une malédiction qui vous fait perdre des points chaque jour jusqu'à ce que vous accomplissiez une tâche.",
                            NomBonusMalus = "Malédiction de l'Oubli",
                            PointBonusMalus = -5
                        },
                        new
                        {
                            IdBonusMalus = 3,
                            DescriptionAttribute = "Un élixir mystérieux qui renforce vos capacités et double votre score actuel.",
                            NomBonusMalus = "Élixir de Puissance",
                            PointBonusMalus = 20
                        },
                        new
                        {
                            IdBonusMalus = 4,
                            DescriptionAttribute = "Un fléau qui vous frappe lorsque vous abandonnez une tâche, vous faisant perdre des points.",
                            NomBonusMalus = "Fléau de l'Abandon",
                            PointBonusMalus = -15
                        });
                });

            modelBuilder.Entity("Rangeur.Domain.Models.LevelRangeur", b =>
                {
                    b.Property<int>("IdLevelRangeur")
                        .HasColumnType("int");

                    b.Property<string>("NomLevelRangeur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLevelRangeur");

                    b.ToTable("RoleRangeurs");

                    b.HasData(
                        new
                        {
                            IdLevelRangeur = 1,
                            NomLevelRangeur = "Apprenti"
                        },
                        new
                        {
                            IdLevelRangeur = 2,
                            NomLevelRangeur = "Compagnon"
                        },
                        new
                        {
                            IdLevelRangeur = 3,
                            NomLevelRangeur = "Artisan"
                        },
                        new
                        {
                            IdLevelRangeur = 4,
                            NomLevelRangeur = "Maître"
                        },
                        new
                        {
                            IdLevelRangeur = 5,
                            NomLevelRangeur = "Grand Maître"
                        },
                        new
                        {
                            IdLevelRangeur = 6,
                            NomLevelRangeur = "Architecte"
                        },
                        new
                        {
                            IdLevelRangeur = 7,
                            NomLevelRangeur = "Visionnaire"
                        },
                        new
                        {
                            IdLevelRangeur = 8,
                            NomLevelRangeur = "Gourou"
                        },
                        new
                        {
                            IdLevelRangeur = 9,
                            NomLevelRangeur = "Virtuose"
                        },
                        new
                        {
                            IdLevelRangeur = 10,
                            NomLevelRangeur = "Sage"
                        });
                });

            modelBuilder.Entity("Rangeur.Domain.Models.Mission", b =>
                {
                    b.Property<int>("IdMission")
                        .HasColumnType("int");

                    b.Property<int?>("BonusMalusIdBonusMalus")
                        .HasColumnType("int");

                    b.Property<int>("BonusMission")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionMission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("MissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomMission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TacheIdTache")
                        .HasColumnType("int");

                    b.HasKey("IdMission");

                    b.HasIndex("BonusMalusIdBonusMalus");

                    b.HasIndex("TacheIdTache");

                    b.ToTable("Missions");

                    b.HasData(
                        new
                        {
                            IdMission = 1,
                            BonusMission = 0,
                            DescriptionMission = "Sauver une tâche en détresse avant que le soleil ne se couche.",
                            NomMission = "Défi du justicier quotidien"
                        },
                        new
                        {
                            IdMission = 2,
                            BonusMission = 0,
                            DescriptionMission = "Réussir au moins 5 taches héroïques dans les 24 dernières heures.",
                            NomMission = "Exploits de la productivité éclair"
                        },
                        new
                        {
                            IdMission = 3,
                            BonusMission = 0,
                            DescriptionMission = "Créer une toute nouvelle mission avec une description aussi unique que le pouvoir d'un super-héros.",
                            NomMission = "Mission de créativité cosmique"
                        },
                        new
                        {
                            IdMission = 4,
                            BonusMission = 0,
                            DescriptionMission = "Unir vos forces avec au moins 2 autres héros pour accomplir une mission digne des légendes.",
                            NomMission = "Légende de la collaboration suprême"
                        });
                });

            modelBuilder.Entity("Rangeur.Domain.Models.Tache", b =>
                {
                    b.Property<int>("IdTache")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEcheance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomTache")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PointBonusMalusIdBonusMalus")
                        .HasColumnType("int");

                    b.Property<int>("PrioriteTaches")
                        .HasColumnType("int");

                    b.Property<string>("Recurrence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statut")
                        .HasColumnType("int");

                    b.HasKey("IdTache");

                    b.HasIndex("PointBonusMalusIdBonusMalus");

                    b.ToTable("Taches");

                    b.HasData(
                        new
                        {
                            IdTache = 1,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3214),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Laver les vêtements",
                            NomTache = "Faire la lessive",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 2,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3242),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Nettoyer les sols avec l'aspirateur",
                            NomTache = "Passer l'aspirateur",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 3,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3250),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Nettoyer les assiettes, verres et couverts",
                            NomTache = "Laver la vaisselle",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 4,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3258),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Donner un bain au chien et le sécher",
                            NomTache = "Laver le chien",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 5,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3265),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Organiser les outils et les équipements dans le garage",
                            NomTache = "Ranger le garage",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 6,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3273),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Vider la poubelle et la mettre à l'extérieur pour la collecte des déchets",
                            NomTache = "Sortir la poubelle",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 7,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3280),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Préparer le repas du soir pour la famille",
                            NomTache = "Faire le souper",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 8,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3288),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Acheter les produits alimentaires et autres nécessités",
                            NomTache = "Faire les courses",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        },
                        new
                        {
                            IdTache = 9,
                            DateCreation = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(3296),
                            DateDebut = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateEcheance = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Faire en sorte que le chien soit aussi propre que son maître après une séance de saut dans les flaques de boue.",
                            NomTache = "Laver le chien",
                            PrioriteTaches = 0,
                            Recurrence = "Non",
                            Statut = 0
                        });
                });

            modelBuilder.Entity("Rangeur.Domain.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDerniereConnexion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LevelRangeurIdLevelRangeur")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PseudoUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int?>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.HasIndex("LevelRangeurIdLevelRangeur");

                    b.HasIndex("PseudoUser")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2725),
                            DateNaissance = new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ariana.grande@example.com",
                            Nom = "Grande",
                            Password = "password123",
                            Prenom = "Ariana",
                            PseudoUser = "ArianaGrande",
                            Role = "Standard",
                            Score = 100,
                            Telephone = 123456789
                        },
                        new
                        {
                            IdUser = 2,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2820),
                            DateNaissance = new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ed.sheeran@example.com",
                            Nom = "Sheeran",
                            Password = "password456",
                            Prenom = "Ed",
                            PseudoUser = "EdSheeran",
                            Role = "Standard",
                            Score = 150,
                            Telephone = 987654321
                        },
                        new
                        {
                            IdUser = 3,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2824),
                            DateNaissance = new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "beyonce.knowles@example.com",
                            Nom = "Knowles",
                            Password = "password789",
                            Prenom = "Beyoncé",
                            PseudoUser = "Beyonce",
                            Role = "Standard",
                            Score = 200,
                            Telephone = 555555555
                        },
                        new
                        {
                            IdUser = 4,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2828),
                            DateNaissance = new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tom.hanks@example.com",
                            Nom = "Hanks",
                            Password = "password123",
                            Prenom = "Tom",
                            PseudoUser = "TomHanks",
                            Role = "Standard",
                            Score = 100,
                            Telephone = 123456789
                        },
                        new
                        {
                            IdUser = 5,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2831),
                            DateNaissance = new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jennifer.lawrence@example.com",
                            Nom = "Lawrence",
                            Password = "password456",
                            Prenom = "Jennifer",
                            PseudoUser = "JenniferLawrence",
                            Role = "Standard",
                            Score = 150,
                            Telephone = 987654321
                        },
                        new
                        {
                            IdUser = 6,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2834),
                            DateNaissance = new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "leonardo.dicaprio@example.com",
                            Nom = "DiCaprio",
                            Password = "password789",
                            Prenom = "Leonardo",
                            PseudoUser = "LeonardoDiCaprio",
                            Role = "Standard",
                            Score = 200,
                            Telephone = 555555555
                        },
                        new
                        {
                            IdUser = 7,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2838),
                            DateNaissance = new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "brad.pitt@example.com",
                            Nom = "Pitt",
                            Password = "password123",
                            Prenom = "Brad",
                            PseudoUser = "BradPitt",
                            Role = "Standard",
                            Score = 180,
                            Telephone = 111222333
                        },
                        new
                        {
                            IdUser = 8,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2846),
                            DateNaissance = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "scarlett.johansson@example.com",
                            Nom = "Johansson",
                            Password = "password456",
                            Prenom = "Scarlett",
                            PseudoUser = "ScarlettJohansson",
                            Role = "Standard",
                            Score = 220,
                            Telephone = 444555666
                        },
                        new
                        {
                            IdUser = 9,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2849),
                            DateNaissance = new DateTime(1954, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "denzel.washington@example.com",
                            Nom = "Washington",
                            Password = "password789",
                            Prenom = "Denzel",
                            PseudoUser = "DenzelWashington",
                            Role = "Standard",
                            Score = 250,
                            Telephone = 777888999
                        },
                        new
                        {
                            IdUser = 10,
                            DateDerniereConnexion = new DateTime(2024, 4, 17, 10, 35, 9, 375, DateTimeKind.Local).AddTicks(2853),
                            DateNaissance = new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucietonelli@gmail.com",
                            Nom = "Tonelli",
                            Password = "password123",
                            Prenom = "Lucie",
                            PseudoUser = "Lucie",
                            Role = "Admin",
                            Score = 250,
                            Telephone = 777888999
                        });
                });

            modelBuilder.Entity("TacheUser", b =>
                {
                    b.Property<int>("TachesIdTache")
                        .HasColumnType("int");

                    b.Property<int>("UsersIdUser")
                        .HasColumnType("int");

                    b.HasKey("TachesIdTache", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("TacheUser");
                });

            modelBuilder.Entity("MissionUser", b =>
                {
                    b.HasOne("Rangeur.Domain.Models.Mission", null)
                        .WithMany()
                        .HasForeignKey("MissionsIdMission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rangeur.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rangeur.Domain.Models.Mission", b =>
                {
                    b.HasOne("Rangeur.Domain.Models.BonusMalus", "BonusMalus")
                        .WithMany()
                        .HasForeignKey("BonusMalusIdBonusMalus");

                    b.HasOne("Rangeur.Domain.Models.Tache", null)
                        .WithMany("Missions")
                        .HasForeignKey("TacheIdTache");

                    b.Navigation("BonusMalus");
                });

            modelBuilder.Entity("Rangeur.Domain.Models.Tache", b =>
                {
                    b.HasOne("Rangeur.Domain.Models.BonusMalus", "PointBonusMalus")
                        .WithMany("Taches")
                        .HasForeignKey("PointBonusMalusIdBonusMalus");

                    b.Navigation("PointBonusMalus");
                });

            modelBuilder.Entity("Rangeur.Domain.Models.User", b =>
                {
                    b.HasOne("Rangeur.Domain.Models.LevelRangeur", "LevelRangeur")
                        .WithMany("Users")
                        .HasForeignKey("LevelRangeurIdLevelRangeur");

                    b.Navigation("LevelRangeur");
                });

            modelBuilder.Entity("TacheUser", b =>
                {
                    b.HasOne("Rangeur.Domain.Models.Tache", null)
                        .WithMany()
                        .HasForeignKey("TachesIdTache")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rangeur.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rangeur.Domain.Models.BonusMalus", b =>
                {
                    b.Navigation("Taches");
                });

            modelBuilder.Entity("Rangeur.Domain.Models.LevelRangeur", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Rangeur.Domain.Models.Tache", b =>
                {
                    b.Navigation("Missions");
                });
#pragma warning restore 612, 618
        }
    }
}
