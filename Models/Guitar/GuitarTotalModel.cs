using System.Collections.Generic;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Models.Guitar
{
    public class GuitarTotalModel
    {
        public Dictionary<string, List<MainServiceModel>> dictGuitarAmplifierViewModel;

        public Dictionary<string, List<MainServiceModel>> dictGuitarCabinetViewModel;

        public IEnumerable<int> allIds;
    }
}