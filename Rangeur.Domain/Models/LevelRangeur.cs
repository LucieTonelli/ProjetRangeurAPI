using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class LevelRangeur
    {
        [Key]
        public int IdLevelRangeur { get; set; } = 0;
        public string NomLevelRangeur { get; set; } = "Apprenti";
        public ICollection<User>? Users { get; set; }
    }
}
