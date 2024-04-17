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
    internal class LevelRangeurConfiguration : IEntityTypeConfiguration<LevelRangeur>
    {
        public void Configure(EntityTypeBuilder<LevelRangeur> builder)
        {

                builder.Property(p => p.IdLevelRangeur).ValueGeneratedNever(); // retirer l'auto-incrémentation

            builder.HasData(
            new LevelRangeur { IdLevelRangeur = 1, NomLevelRangeur = "Apprenti" },
            new LevelRangeur { IdLevelRangeur = 2, NomLevelRangeur = "Compagnon" },
            new LevelRangeur { IdLevelRangeur = 3, NomLevelRangeur = "Artisan" },
            new LevelRangeur { IdLevelRangeur = 4, NomLevelRangeur = "Maître" },
            new LevelRangeur { IdLevelRangeur = 5, NomLevelRangeur = "Grand Maître" },
            new LevelRangeur { IdLevelRangeur = 6, NomLevelRangeur = "Architecte" },
            new LevelRangeur { IdLevelRangeur = 7, NomLevelRangeur = "Visionnaire" },
            new LevelRangeur { IdLevelRangeur = 8, NomLevelRangeur = "Gourou" },
            new LevelRangeur { IdLevelRangeur = 9, NomLevelRangeur = "Virtuose" },
            new LevelRangeur { IdLevelRangeur = 10, NomLevelRangeur = "Sage" });
        }
    }
}
