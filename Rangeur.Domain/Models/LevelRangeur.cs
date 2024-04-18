using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class LevelRangeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLevelRangeur { get; set; } = 1;
        public string NomLevelRangeur { get; set; } = "Apprenti";
        public ICollection<User>? Users { get; set; }
    }
}


//Apprenti
//Compagnon
//Artisan
//Maître
//Grand Maître
//Architecte
//Visionnaire
//Gourou
//Virtuose
//Sage