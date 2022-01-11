using System.Collections.Generic;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Models.Keyboard
{
    public class KeyboardTotalModel
    {
        public Dictionary<string, List<MainServiceModel>> dictKeyboardViewModel;

        public Dictionary<string, List<MainServiceModel>> dictMidiControllerViewModel;

        public IEnumerable<int> allIds;
    }
}