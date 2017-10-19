using Microsoft.EntityFrameworkCore;

namespace AnimalSanctuary.Models
{
    public class TestDbContext : AnimalSanctuaryDbContext
    {
        public override DbSet<Veterinarian> Veterinarians { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=animal_sanctuary;uid=root;pwd=root;");
        }
    }
}
