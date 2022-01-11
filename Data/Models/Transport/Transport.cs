using System.ComponentModel.DataAnnotations;

using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Data.Models.Transport
{
    public class Transport
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Kind { get; set; }

        [Required]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(TransportRegNumber)]
        [RegularExpression(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$")]
        public string RegNumber { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        public int Count { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public int CategoryId { get; set; }

        public Categories Category { get; set; }

        // I am not sure about that!
    }
}