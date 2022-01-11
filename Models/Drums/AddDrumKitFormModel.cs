using System.ComponentModel.DataAnnotations;
using SoundAndDance_v2.Data.Models;
using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Models.Drums
{
    public class AddDrumKitFormModel
    {
        [Required(ErrorMessage = "Please enter a BRAND")]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

        [StringLength(ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick1 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNKick1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick2 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNKick2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick3 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNKick3 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick4 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNKick4 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string RackTom1 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNRackTom1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string RackTom2 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNRackTom2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string RackTom3 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNRackTom3 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string RackTom4 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNRackTom4 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string FloorTom1 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNFloorTom1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string FloorTom2 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNFloorTom2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string FloorTom3 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNFloorTom3 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string FloorTom4 { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SNFloorTom4 { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        [Required(ErrorMessage = "Please enter a PRICE")]
        [RegularExpression(@"^\d*[.]?\d+$", ErrorMessage = "Invalid PRICE")]
        public decimal? UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public int CategoryId { get; set; } = 1;

        public Categories Categories { get; set; }
    }
}