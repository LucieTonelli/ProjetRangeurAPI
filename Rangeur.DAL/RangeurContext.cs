using Microsoft.EntityFrameworkCore;
using Rangeur.Domain.Models;

namespace Rangeur.DAL
{
    public class RangeurContext : DbContext
    {
        public DbSet<BonusMalus> BonusMalus { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Tache> Taches { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<RoleRangeur> RoleRangeurs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Server=E6K-VDI20415\\TFTIC;Database=DbRangeur;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
