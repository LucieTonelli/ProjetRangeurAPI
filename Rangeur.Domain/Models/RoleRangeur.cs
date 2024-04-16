using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.Domain.Models
{
    public class RoleRangeur
    {
        [Key]
        public int IdRole { get; set; }
        public string NomRole { get; set; } = "Standard";
        public ICollection<User>? Users { get; set; }
    }
}
