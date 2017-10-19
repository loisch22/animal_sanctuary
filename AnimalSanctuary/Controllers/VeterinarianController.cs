using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalSanctuary.Models;

namespace AnimalSanctuary.Controllers
{
    public class VeterinarianController : Controller
    {
        private IItemRepository vetRepo;

        public VeterinarianController(IItemRepository thisRepo = null)
        {
            if (thisRepo == null)
            {
                this.vetRepo = new EFItemRepository();
            }
            else
            {
                this.vetRepo = thisRepo;    
            }
        }

        public ViewResult Index()
        {
            return View(vetRepo.Veterinarians.ToList());
        }

        public IActionResult Details(int id)
        {
            Veterinarian thisVet = vetRepo.Veterinarians.FirstOrDefault(x => x.VeterinarianId == id);
            return View(thisVet);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Veterinarian veterinarian)
        {
            vetRepo.Save(veterinarian);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Veterinarian thisVet = vetRepo.Veterinarians.FirstOrDefault(x => x.VeterinarianId == id);
            return View(thisVet);
        }

        [HttpPost]
        public IActionResult Edit(Veterinarian veterinarian)
        {
            vetRepo.Edit(veterinarian);

            return RedirectToAction("Index");
        }

    }
}
