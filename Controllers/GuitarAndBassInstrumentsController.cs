using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SoundAndDance_v2.Models.GuitarAndBassInstrument;
using SoundAndDance_v2.Services.InstrumentServices;

namespace SoundAndDance_v2.Controllers
{
    public class GuitarAndBassInstrumentsController : Controller
    {
        private readonly IInstrumentService instrument;

        public GuitarAndBassInstrumentsController(IInstrumentService instrument)
        {
            this.instrument = instrument;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GuitarAndBassInstrumentsAll()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult AcousticGuitarsAll()
        {
            var allAcGuitars = instrument.AllAcousticGuitars();

            return View(allAcGuitars);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddAcousticGuitar()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddAcousticGuitar(int categoryId, AcousticGuitarViewModel acGuitarModel)
        {
            if (!ModelState.IsValid)
            {
                return View(acGuitarModel);
            }

            instrument.Create(categoryId, acGuitarModel.Brand, acGuitarModel.Model, acGuitarModel.SerialNumber, acGuitarModel.Notes, (int)acGuitarModel.Count, (decimal)acGuitarModel.UnitPrice, acGuitarModel.TotalPrice);

            return Redirect("/GuitarAndBassInstruments/AcousticGuitarsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult _DeleteConfirmationPartial(int id, int categoryId)
        {
            var deleteModel = instrument.DeleteConfirmation(id, categoryId);

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
            instrument.Delete(id, categoryId);

            if (categoryId == 9)
            {
                return Redirect("/GuitarAndBassInstruments/AcousticGuitarsAll");
            }
            else if (categoryId == 10)
            {
                return Redirect("/GuitarAndBassInstruments/BassGuitarsAll");
            }

            return Redirect("/GuitarAndBassInstruments/ElectricGuitarsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditAcousticGuitar(int id, int categoryId)
        {
            var currentAcGuitar = instrument.EditAcousticGuitar(id, categoryId);

            return View(currentAcGuitar);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditAcousticGuitar(int id, AcousticGuitarViewModel acGuitarModel, int categoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(acGuitarModel);
            }

            instrument.EditAcousticGuitarPost(id, acGuitarModel.Brand, acGuitarModel.Model, acGuitarModel.SerialNumber, acGuitarModel.Notes, (int)acGuitarModel.Count, (decimal)acGuitarModel.UnitPrice, categoryId);

            return Redirect("/GuitarAndBassInstruments/AcousticGuitarsAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult BassGuitarsAll()
        {
            var allBassGuitars = instrument.AllBassGuitars();

            return View(allBassGuitars);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddBassGuitar()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddBassGuitar(int categoryId, BassGuitarViewModel bassGuitarModel)
        {
            if (!ModelState.IsValid)
            {
                return View(bassGuitarModel);
            }

            instrument.Create(categoryId, bassGuitarModel.Brand, bassGuitarModel.Model, bassGuitarModel.SerialNumber, bassGuitarModel.Notes, (int)bassGuitarModel.Count, (decimal)bassGuitarModel.UnitPrice, bassGuitarModel.TotalPrice);

            return Redirect("/GuitarAndBassInstruments/BassGuitarsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditBassGuitar(int id, int categoryId)
        {
            var currentBassGuitar = instrument.EditBassGuitar(id, categoryId);

            return View(currentBassGuitar);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditBassGuitar(int id, BassGuitarViewModel bassGuitarModel, int priceId)
        {
            if (!ModelState.IsValid)
            {
                return View(bassGuitarModel);
            }

            instrument.EditBassGuitarPost(id, bassGuitarModel.Brand, bassGuitarModel.Model, bassGuitarModel.SerialNumber, bassGuitarModel.Notes, (int)bassGuitarModel.Count, (decimal)bassGuitarModel.UnitPrice, bassGuitarModel.CategoryId);

            return Redirect("/GuitarAndBassInstruments/BassGuitarsAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult ElectricGuitarsAll()
        {
            var allElGuitars = instrument.AllElectricGuitars();

            return View(allElGuitars);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddElectricGuitar()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddElectricGuitar(int categoryId, ElectricGuitarViewModel elGuitarModel)
        {
            if (!ModelState.IsValid)
            {
                return View(elGuitarModel);
            }

            instrument.Create(categoryId, elGuitarModel.Brand, elGuitarModel.Model, elGuitarModel.SerialNumber, elGuitarModel.Notes, (int)elGuitarModel.Count, (decimal)elGuitarModel.UnitPrice, elGuitarModel.TotalPrice);

            return Redirect("/GuitarAndBassInstruments/ElectricGuitarsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditElectricGuitar(int id, int categoryId)
        {
            var currentElGuitar = instrument.EditElectricGuitar(id, categoryId);

            return View(currentElGuitar);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditElectricGuitar(int id, ElectricGuitarViewModel elGuitarModel, int priceId)
        {
            if (!ModelState.IsValid)
            {
                return View(elGuitarModel);
            }

            instrument.EditElectricGuitarPost(id, elGuitarModel.Brand, elGuitarModel.Model, elGuitarModel.SerialNumber, elGuitarModel.Notes, (int)elGuitarModel.Count, (decimal)elGuitarModel.UnitPrice, elGuitarModel.CategoryId);

            return Redirect("/GuitarAndBassInstruments/ElectricGuitarsAll");
        }
    }
}