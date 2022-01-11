using System.Collections.Generic;

namespace SoundAndDance_v2.Models.Drums
{
    public class TotalModel
    {
        public Dictionary<string, List<CymbalViewModel>> dict;

        public IEnumerable<int> allIds;
    }
}