using System.ComponentModel.DataAnnotations;
using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Models.Drums
{
    public class CymbalViewModel : MainModel
    {
        [MaxLength(50)]
        public string Kind { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Size { get; set; }
    }
}