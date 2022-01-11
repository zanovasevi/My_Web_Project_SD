using System.ComponentModel.DataAnnotations;

using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Data.Models.Miscellaneous
{
    public class Cabel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Kind { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Length { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        public int Count { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public int CategoryId { get; set; }

        public Categories Category { get; set; }
    }
}