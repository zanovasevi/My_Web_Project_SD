using System.Collections.Generic;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Models.GuitarAndBassInstrument
{
    public class InstrumentTotalModel
    {
        public Dictionary<string, List<MainServiceModel>> dictAcousticGuitarViewModel;

        public Dictionary<string, List<MainServiceModel>> dictBassGuitarViewModel;

        public Dictionary<string, List<MainServiceModel>> dictElectricGuitarViewModel;

        public IEnumerable<int> allIds;
    }
}