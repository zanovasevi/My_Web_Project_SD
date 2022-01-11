using System.Collections.Generic;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Models.Bass
{
    public class BassTotalModel
    {
        public Dictionary<string, List<MainServiceModel>> dictBassAmplifierViewModel;

        public Dictionary<string, List<MainServiceModel>> dictBassCabinetViewModel;

        public IEnumerable<int> allIds;        
    }
}