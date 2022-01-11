using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SoundAndDance_v2.Models.Drums;
using SoundAndDance_v2.Services.DrumsServices;

using static SoundAndDance_v2.Constants;

namespace SoundAndDance_v2.Controllers
{
    public class DrumsController : Controller
    {
        private readonly IDrumsService drums;

        public DrumsController(IDrumsService drums)
        {
            this.drums = drums;
        }

        [HttpGet]
        [Authorize]
        public IActionResult DrumsCategoryAll()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult AcousticDrumKitsAll()
        {
            var allDrums = drums.AllDrumKits();

            return View(allDrums);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddDrumKit()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddDrumKit(int categoryId, AddDrumKitFormModel drumModel)
        {                                                             
            if(!ModelState.IsValid)
            {
                return View(drumModel);
            }

            drums.Create(categoryId, drumModel, null);

            return Redirect("/Drums/AcousticDrumKitsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult _DeleteConfirmationPartial(int id, int categoryId)
        {
            var deleteModel = drums.DeleteConfirmation(id, categoryId);

            if(deleteModel == null)
            {
                return BadRequest();
            }

            return View(deleteModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int id, int categoryId)
        {
            drums.Delete(id, categoryId);

            if(categoryId == 1)
            {
                return Redirect("/Drums/AcousticDrumKitsAll");
            }

            return Redirect("/Drums/CymbalsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditDrumKit(int id, int categoryId)
        {
            var currentDrums = drums.EditDrumKit(id, categoryId);

            return View(currentDrums);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditDrumKit(int id, AddDrumKitFormModel drumModel, int priceId)
        {
            if (!ModelState.IsValid)
            {
                return View(drumModel);
            }

            drums.EditDrumKitPost(id, drumModel, priceId);

            return Redirect("/Drums/AcousticDrumKitsAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult CymbalsAll()
        {
            var cymbals = drums.AllCymbals();

            return View(cymbals);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddCymbal()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddCymbal(int categoryId, CymbalViewModel cymbalModel)
        {
            if (!ModelState.IsValid)
            {
                return View(cymbalModel);
            }

            drums.Create(categoryId, null, cymbalModel);

            return Redirect("/Drums/CymbalsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditCymbal(int id, int categoryId)
        {
            var currentCymbal = drums.EditCybal(id, categoryId);

            return View(currentCymbal);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditCymbal(int id, CymbalViewModel cymbalModel, int priceId)
        {
            if (!ModelState.IsValid)
            {
                return View(cymbalModel);
            }

            drums.EditCymbalPost(id, cymbalModel, priceId);

            return Redirect("/Drums/CymbalsAll");
        }
    }
}