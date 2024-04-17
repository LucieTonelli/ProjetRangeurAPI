using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class Tache
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTache { get; set; }
        public required string NomTache { get; set; }
        public int Statut { get; set; } = 0;
        public required int PrioriteTaches { get; set; } = 0;
        public required string Recurrence { get; set; } = "Non";
        public string? Description { get; set; }

        public DateTime DateCreation { get; set; } = DateTime.Now;
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public DateTime DateEcheance { get; set; }
        public ICollection<User>? Users { get; set; }

        public ICollection<Mission>? Missions { get; set; }

        public BonusMalus? PointBonusMalus { get; set; }
    }
}
