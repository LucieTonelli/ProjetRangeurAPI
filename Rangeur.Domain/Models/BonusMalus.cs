using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class BonusMalus
    {
        [Key]
        public int IdBonusMalus { get; set; }
        public required string NomBonusMalus { get; set; }
        public required string DescriptionAttribute { get; set; }
        public int PointBonusMalus { get; set; } = 0;

        public ICollection<Tache>? Taches { get; set; }

    }
}
