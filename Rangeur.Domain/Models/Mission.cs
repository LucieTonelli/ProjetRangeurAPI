using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMission { get; set; }
        public required string NomMission { get; set; }
        public required string DescriptionMission { get; set; }
        public DateTime? MissionDate { get; set; }
        public int BonusMission { get; set; }
        public ICollection<User>? Users { get; set; }

        public BonusMalus? BonusMalus { get; set; }
    }
}
