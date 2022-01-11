using System.ComponentModel.DataAnnotations;
using SoundAndDance_v2.Data.Models;
using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Models
{
    public class MainModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a BRAND")]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

        [StringLength(ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SerialNumber { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Please enter a COUNT")]
        [Range(0, 1000, ErrorMessage = "Please enter a valid COUNT")]
        public int? Count { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        [Required(ErrorMessage = "Please enter a PRICE")]
        [RegularExpression(@"^\d*[.]?\d+$", ErrorMessage = "Invalid PRICE")]
        public decimal? UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public int CategoryId { get; set; }

        public Categories Categories { get; set; }
    }
}