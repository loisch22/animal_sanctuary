using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalSanctuary.Models
{

    public interface IItemRepository
    {
        IQueryable<Veterinarian> Veterinarians { get; }
        Veterinarian Save(Veterinarian veterinarian);
        Veterinarian Edit(Veterinarian veterinarian);
        void Remove(Veterinarian veterinarian);

        //IQueryable<Animal> Animals { get; }
        //Animal Save(Animal animal);
        //Animal Edit(Animal animal);
        //void Remove(Animal animal);
    }

}
