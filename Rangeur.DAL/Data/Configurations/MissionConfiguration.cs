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
    internal class MissionConfiguration : IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            builder.Property(p => p.IdMission).ValueGeneratedNever(); // retirer l'auto-incrémentation

            builder.HasData(

            new Mission
            {
                IdMission = 1,
                NomMission = "Défi du justicier quotidien",
                DescriptionMission = "Sauver une tâche en détresse avant que le soleil ne se couche.",
                MissionDate = null,
                BonusMission = 0,
                Users = null,
                BonusMalus = null
            },
            new Mission
            {
                IdMission = 2,
                NomMission = "Exploits de la productivité éclair",
                DescriptionMission = "Réussir au moins 5 taches héroïques dans les 24 dernières heures.",
                MissionDate = null,
                BonusMission = 0,
                Users = null,
                BonusMalus = null
            },
            new Mission
            {
                IdMission = 3,
                NomMission = "Mission de créativité cosmique",
                DescriptionMission = "Créer une toute nouvelle mission avec une description aussi unique que le pouvoir d'un super-héros.",
                MissionDate = null,
                BonusMission = 0,
                Users = null,
                BonusMalus = null
            },
            new Mission
            {
                IdMission = 4,
                NomMission = "Légende de la collaboration suprême",
                DescriptionMission = "Unir vos forces avec au moins 2 autres héros pour accomplir une mission digne des légendes.",
                MissionDate = null,
                BonusMission = 0,
                Users = null,
                BonusMalus = null
            });




        }
    }
}
