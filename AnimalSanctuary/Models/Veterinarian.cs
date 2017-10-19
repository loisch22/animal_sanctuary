using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AnimalSanctuary.Models
{
    [Table("Veterinarians")]
    public class Veterinarian
    {
        [Key]
        public int VeterinarianId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public override bool Equals(System.Object otherVet)
        {
            if (!(otherVet is Veterinarian))
            {
                return false;
            }
            else
            {
                Veterinarian newVet = (Veterinarian)otherVet;
                return this.VeterinarianId.Equals(newVet.VeterinarianId);
            }
        }

        public override int GetHashCode()
        {
            return this.VeterinarianId.GetHashCode();
        }
    }
}
