using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SoundAndDance_v2.Models.Keyboard;
using SoundAndDance_v2.Services.KeyboardServices;

namespace SoundAndDance_v2.Controllers
{
    public class KeyboardController : Controller
    {
        private readonly IKeyboardService keyboard;

        public KeyboardController(IKeyboardService keyboard)
        {
            this.keyboard = keyboard;
        }

        [HttpGet]
        [Authorize]
        public IActionResult KeyboardCategoryAll()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult KeyboardsAll()
        {
            var allKeyboards = keyboard.AllKeyboards();

            return View(allKeyboards);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddKeyboard()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddKeyboard(int categoryId, KeyboardViewModel keyboardModel)
        {
            if (!ModelState.IsValid)
            {
                return View(keyboardModel);
            }

            keyboard.Create(categoryId, keyboardModel.Brand, keyboardModel.Model, keyboardModel.SerialNumber, keyboardModel.Notes, (int)keyboardModel.Count, (decimal)keyboardModel.UnitPrice, keyboardModel.TotalPrice);

            return Redirect("/Keyboard/KeyboardsAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult _DeleteConfirmationPartial(int id, int categoryId)
        {
            var deleteModel = keyboard.DeleteConfirmation(id, categoryId);

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
            keyboard.Delete(id, categoryId);

            if (categoryId == 7)
            {
                return Redirect("/Keyboard/KeyboardsAll");
            }

            return Redirect("/Keyboard/MidiControllersAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditKeyboard(int id, int categoryId)
        {
            var currentKeyboard = keyboard.EditKeyboard(id, categoryId);

            return View(currentKeyboard);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditKeyboard(int id, KeyboardViewModel keyboardModel, int categoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(keyboardModel);
            }

            keyboard.EditKeyboardPost(id, keyboardModel.Brand, keyboardModel.Model, keyboardModel.SerialNumber, keyboardModel.Notes, (int)keyboardModel.Count, (decimal)keyboardModel.UnitPrice, categoryId);

            return Redirect("/Keyboard/KeyboardsAll");
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        [Authorize]
        public IActionResult MidiControllersAll()
        {
            var allMidiControllers = keyboard.AllMidiControllers();

            return View(allMidiControllers);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddMidiController()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddMidiController(int categoryId, MidiControllerViewModel midiControllerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(midiControllerModel);
            }

            keyboard.Create(categoryId, midiControllerModel.Brand, midiControllerModel.Model, midiControllerModel.SerialNumber, midiControllerModel.Notes, (int)midiControllerModel.Count, (decimal)midiControllerModel.UnitPrice, midiControllerModel.TotalPrice);

            return Redirect("/Keyboard/MidiControllersAll");
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditMidiController(int id, int categoryId)
        {
            var currentMidiController = keyboard.EditMidiController(id, categoryId);

            return View(currentMidiController);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditMidiController(int id, MidiControllerViewModel midiControllerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(midiControllerModel);
            }

            keyboard.EditMidiControllerPost(id, midiControllerModel.Brand, midiControllerModel.Model, midiControllerModel.SerialNumber, midiControllerModel.Notes, (int)midiControllerModel.Count, (decimal)midiControllerModel.UnitPrice, midiControllerModel.CategoryId);

            return Redirect("/Keyboard/MidiControllersAll");
        }
    }
}