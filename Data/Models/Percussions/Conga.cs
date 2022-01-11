using System.ComponentModel.DataAnnotations;

using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Data.Models.Percussions
{
    public class Conga
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

        [MaxLength(ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Size { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SerialNumber { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        public int Count { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public int CategoryId { get; set; }

        public Categories Category { get; set; }
    }
}