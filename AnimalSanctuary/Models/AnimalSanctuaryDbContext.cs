using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AnimalSanctuary.Models
{

    public class AnimalSanctuaryDbContext : DbContext
    {
        public virtual DbSet<Veterinarian> Veterinarians { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseMySql(@"Server=localhost;Port=8889;database=animal_sanctuary;uid=root;pwd=root;");

    }
}
