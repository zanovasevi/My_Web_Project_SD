using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SoundAndDance_v2.Models.Bass;
using SoundAndDance_v2.Services.BassServices;

namespace SoundAndDance_v2.Controllers
{
    public class BassController : Controller
    {
        private readonly IBassService bass;

        public BassController(IBassService bass)
        {
            this.bass = bass;
        }

        [HttpGet]
        [Authorize]
        public IActionResult BassCategoryAll()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult BassAmplifiersAll()
        {
            var allBassAmplifiers = bass.AllBassAmplifiers();

            return View(allBassAmplifiers);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddBassAmplifier()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddBassAmplifier(int categoryId, BassAmplifierViewModel bassAmpModel)
        {
            if (!ModelState.IsValid)
            {
                return View(bassAmpModel);
            }

            bass.Create(categoryId, bassAmpModel.Brand, bassAmpModel.Model, bassAmpModel.SerialNumber, bassAmpModel.Notes, (int)bassAmpModel.Count, (decimal)bassAmpModel.UnitPrice, bassAmpModel.TotalPrice);

            return Redirect("/Bass/BassAmplifiersAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult _DeleteConfirmationPartial(int id, int categoryId)
        {
            var deleteModel = bass.DeleteConfirmation(id, categoryId);

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
            bass.Delete(id, categoryId);

            if (categoryId == 3)
            {
                return Redirect("/Bass/BassAmplifiersAll");
            }

            return Redirect("/Bass/BassCabinetsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditBassAmplifier(int id, int categoryId)
        {
            var currentBassAmp = bass.EditBassAmplifier(id, categoryId);

            return View(currentBassAmp);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditBassAmplifier(int id, BassAmplifierViewModel bassAmpModel, int categoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(bassAmpModel);
            }

            bass.EditBassAmplifierPost(id, bassAmpModel.Brand, bassAmpModel.Model, bassAmpModel.SerialNumber, bassAmpModel.Notes, (int)bassAmpModel.Count, (decimal)bassAmpModel.UnitPrice, categoryId);

            return Redirect("/Bass/BassAmplifiersAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult BassCabinetsAll()
        {
            var allBassCabinets = bass.AllBassCabinets();

            return View(allBassCabinets);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddBassCabinet()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddBassCabinet(int categoryId, BassCabinetViewModel bassCabModel)
        {
            if (!ModelState.IsValid)
            {
                return View(bassCabModel);
            }

            bass.Create(categoryId, bassCabModel.Brand, bassCabModel.Model, bassCabModel.SerialNumber, bassCabModel.Notes, (int)bassCabModel.Count, (decimal)bassCabModel.UnitPrice, bassCabModel.TotalPrice);

            return Redirect("/Bass/BassCabinetsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditBassCabinet(int id, int categoryId)
        {
            var currentBassCab = bass.EditBassCabinet(id, categoryId);

            return View(currentBassCab);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditBassCabinet(int id, BassCabinetViewModel bassCabModel)
        {
            if (!ModelState.IsValid)
            {
                return View(bassCabModel);
            }

            bass.EditBassCabinetPost(id, bassCabModel.Brand, bassCabModel.Model, bassCabModel.SerialNumber, bassCabModel.Notes, (int)bassCabModel.Count, (decimal)bassCabModel.UnitPrice, bassCabModel.CategoryId);

            return Redirect("/Bass/BassCabinetsAll");
        }
    }
}