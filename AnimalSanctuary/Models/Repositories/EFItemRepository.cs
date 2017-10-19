using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalSanctuary.Models
{

    public class EFItemRepository : IItemRepository
    {
        AnimalSanctuaryDbContext db = new AnimalSanctuaryDbContext();

        public EFItemRepository(AnimalSanctuaryDbContext connection = null)
        {
            if (connection == null)
            {
                this.db = new AnimalSanctuaryDbContext();
            }
            else
            {
                this.db = connection;
            }
        }

        public IQueryable<Veterinarian> Veterinarians 
        {
            get { return db.Veterinarians; }
        }

        public Veterinarian Save(Veterinarian veterinarian)
        {
            db.Veterinarians.Add(veterinarian);
            db.SaveChanges();
            return veterinarian;
        }


        public Veterinarian Edit(Veterinarian veterinarian)
        {
            db.Entry(veterinarian).State = EntityState.Modified;
            db.SaveChanges();
            return veterinarian;
        }

        public void Remove(Veterinarian veterinarian)
        {
            db.Veterinarians.Remove(veterinarian);
            db.SaveChanges();
        }
    }
}
