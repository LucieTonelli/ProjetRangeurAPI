using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rangeur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.DAL.Data.Configurations
{
    internal class TacheConfiguration : IEntityTypeConfiguration<Tache>
    {
        public void Configure(EntityTypeBuilder<Tache> builder)
        {
            builder.Property(p => p.IdTache).ValueGeneratedNever(); // retirer l'auto-incrémentation

            builder.HasData(
            new Tache
            {
                IdTache = 1,
                NomTache = "Faire la lessive",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Laver les vêtements",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 2,
                NomTache = "Passer l'aspirateur",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Nettoyer les sols avec l'aspirateur",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 3,
                NomTache = "Laver la vaisselle",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Nettoyer les assiettes, verres et couverts",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 4,
                NomTache = "Laver le chien",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Donner un bain au chien et le sécher",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 5,
                NomTache = "Ranger le garage",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Organiser les outils et les équipements dans le garage",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 6,
                NomTache = "Sortir la poubelle",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Vider la poubelle et la mettre à l'extérieur pour la collecte des déchets",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 7,
                NomTache = "Faire le souper",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Préparer le repas du soir pour la famille",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 8,
                NomTache = "Faire les courses",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Acheter les produits alimentaires et autres nécessités",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            },

            new Tache
            {
                IdTache = 9,
                NomTache = "Laver le chien",
                Statut = 0,
                PrioriteTaches = 0,
                Recurrence = "Non",
                Description = "Faire en sorte que le chien soit aussi propre que son maître après une séance de saut dans les flaques de boue.",
                DateCreation = DateTime.Now,
                DateDebut = DateTime.Today,
                DateFin = null,
                DateEcheance = DateTime.Today.AddDays(1),
                Users = null,
                Missions = null,
                PointBonusMalus = null
            });

        }
    }
}
