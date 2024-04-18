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
    internal class BonusMalusConfiguration : IEntityTypeConfiguration<BonusMalus>
    {
        public void Configure(EntityTypeBuilder<BonusMalus> builder)
        {
            builder.Property(p => p.IdBonusMalus).ValueGeneratedNever(); // retirer l'auto-incrémentation

            builder.HasData(
                new BonusMalus { IdBonusMalus = 1, NomBonusMalus = "Potion de Résistance", DescriptionAttribute = "Augmente votre résistance contre les obstacles et vous octroie un bonus de points.", PointBonusMalus = 10 },
                new BonusMalus { IdBonusMalus = 2, NomBonusMalus = "Malédiction de l'Oubli", DescriptionAttribute = "Une malédiction qui vous fait perdre des points chaque jour jusqu'à ce que vous accomplissiez une tâche.", PointBonusMalus = -5 },
                new BonusMalus { IdBonusMalus = 3, NomBonusMalus = "Élixir de Puissance", DescriptionAttribute = "Un élixir mystérieux qui renforce vos capacités et double votre score actuel.", PointBonusMalus = 20 },
                new BonusMalus { IdBonusMalus = 4, NomBonusMalus = "Fléau de l'Abandon", DescriptionAttribute = "Un fléau qui vous frappe lorsque vous abandonnez une tâche, vous faisant perdre des points.", PointBonusMalus = -15 }
            );
        }

    }
}

