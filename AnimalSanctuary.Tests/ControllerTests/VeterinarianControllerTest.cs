using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using AnimalSanctuary.Models;
using AnimalSanctuary.Controllers;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace AnimalSanctuary.Tests
{
    [TestClass]
    public class VeterinarianControllerTest
    {
        Mock<IItemRepository> mock = new Mock<IItemRepository>();

        EFItemRepository db = new EFItemRepository(new TestDbContext());

        private void DbSetUp()
        {   //Setting up mock data to test
            mock.Setup(mock => mock.Veterinarians).Returns(new Veterinarian[]
            {
                new Veterinarian(){VeterinarianId = 1, Name = "Susan Wells", Specialty = "Birds"},
                new Veterinarian(){VeterinarianId = 2, Name = "Derrick Green", Specialty = "Zebras"},
                new Veterinarian(){VeterinarianId = 3, Name = "Chelsea Mitchell", Specialty = "Elephants" }
            }.AsQueryable());
        }

        [TestMethod]
        public void Mock_GetViewResultIndex_Test()
        {
            DbSetUp();
            VeterinarianController controller = new VeterinarianController();

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void Mock_GetModelList_Test()
        {
            DbSetUp();
            ViewResult indexView = new VeterinarianController().Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(List<Veterinarian>));
        }

        [TestMethod]
        public void Mock_ConfirmEntry_Test()
        {
            DbSetUp();
            VeterinarianController controller = new VeterinarianController(mock.Object);
            Veterinarian testVet = new Veterinarian();
            testVet.Name = "Susan Wells";
            testVet.Specialty = "Birds";
            testVet.VeterinarianId = 1;

            ViewResult indexView = controller.Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Veterinarian>;

            CollectionAssert.Contains(collection, testVet);
        }

        [TestMethod]
        public void Db_CreateNewVet_Test()
        {
            VeterinarianController controller = new VeterinarianController(db);
            Veterinarian newVet = new Veterinarian();
            newVet.Name = "Matthew Adams";
            newVet.Specialty = "Lions";

            controller.Create(newVet);
            var collection = (controller.Index() as ViewResult).ViewData.Model as List<Veterinarian>;


            CollectionAssert.Contains(collection, newVet);
        }

        [TestMethod]
        public void Db_EditVetDetails_Test()
        {
            VeterinarianController controller = new VeterinarianController();

        }
    }
}
