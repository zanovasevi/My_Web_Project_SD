using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SoundAndDance_v2.Models.Guitar;
using SoundAndDance_v2.Services.GuitarServices;

namespace SoundAndDance_v2.Controllers
{
    public class GuitarAmpAndCabsController : Controller
    {
        private readonly IGuitarService guitar;

        public GuitarAmpAndCabsController(IGuitarService guitar)
        {
            this.guitar = guitar;
        }

        public IActionResult GuitarAmpAndCabsCategoryAll()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult GuitarAmplifiersAll()
        {
            var allGuitarAmplifiers = guitar.AllGuitarAmplifiers();

            return View(allGuitarAmplifiers);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddGuitarAmplifier()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddGuitarAmplifier(int categoryId, GuitarAmplifierViewModel guitarAmpModel)
        {
            if (!ModelState.IsValid)
            {
                return View(guitarAmpModel);
            }

            guitar.Create(categoryId, guitarAmpModel.Brand, guitarAmpModel.Model, guitarAmpModel.SerialNumber, guitarAmpModel.Notes, (int)guitarAmpModel.Count, (decimal)guitarAmpModel.UnitPrice, guitarAmpModel.TotalPrice);

            return Redirect("/GuitarAmpAndCabs/GuitarAmplifiersAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult _DeleteConfirmationPartial(int id, int categoryId)
        {
            var deleteModel = guitar.DeleteConfirmation(id, categoryId);

            if (deleteModel == null)
            {
                return BadRequest();
            }

            return View(deleteModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int id, int categoryId)
        {
            guitar.Delete(id, categoryId);

            if (categoryId == 5)
            {
                return Redirect("/GuitarAmpAndCabs/GuitarAmplifiersAll");
            }

            return Redirect("/GuitarAmpAndCabs/GuitarCabinetsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditGuitarAmplifier(int id, int categoryId)
        {
            var currentGuitarAmp = guitar.EditGuitarAmplifier(id, categoryId);

            return View(currentGuitarAmp);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditGuitarAmplifier(int id, GuitarAmplifierViewModel guitarAmpModel, int categoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(guitarAmpModel);
            }

            guitar.EditGuitarAmplifierPost(id, guitarAmpModel.Brand, guitarAmpModel.Model, guitarAmpModel.SerialNumber, guitarAmpModel.Notes, (int)guitarAmpModel.Count, (decimal)guitarAmpModel.UnitPrice, categoryId);

            return Redirect("/GuitarAmpAndCabs/GuitarAmplifiersAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult GuitarCabinetsAll()
        {
            var allGuitarCabinets = guitar.AllGuitarCabinets();

            return View(allGuitarCabinets);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddGuitarCabinet()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddGuitarCabinet(int categoryId, GuitarCabinetViewModel guitarCabModel)
        {
            if (!ModelState.IsValid)
            {
                return View(guitarCabModel);
            }

            guitar.Create(categoryId, guitarCabModel.Brand, guitarCabModel.Model, guitarCabModel.SerialNumber, guitarCabModel.Notes, (int)guitarCabModel.Count, (decimal)guitarCabModel.UnitPrice, guitarCabModel.TotalPrice);

            return Redirect("/GuitarAmpAndCabs/GuitarCabinetsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditGuitarCabinet(int id, int categoryId)
        {
            var currentGuitarCab = guitar.EditGuitarCabinet(id, categoryId);

            return View(currentGuitarCab);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditGuitarCabinet(int id, GuitarCabinetViewModel guitarCabModel)
        {
            if (!ModelState.IsValid)
            {
                return View(guitarCabModel);
            }

            guitar.EditGuitarCabinetPost(id, guitarCabModel.Brand, guitarCabModel.Model, guitarCabModel.SerialNumber, guitarCabModel.Notes, (int)guitarCabModel.Count, (decimal)guitarCabModel.UnitPrice, guitarCabModel.CategoryId);

            return Redirect("/GuitarAmpAndCabs/GuitarCabinetsAll");
        }
    }
}