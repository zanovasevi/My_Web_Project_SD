using System.ComponentModel.DataAnnotations;

using static SoundAndDance_v2.Data.DataConstants;

namespace SoundAndDance_v2.Data.Models.Drums
{
    public class ElectronicDrumKit
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

        [MaxLength(ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(SerialNumberMaxLength)]
        public string SerialNumber { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Kick2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string SnareDrum1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string SnareDrum2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom3 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom4 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom5 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Tom6 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string HiHat { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Ride { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Crash1 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Crash2 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Crash3 { get; set; }

        [MaxLength(ItemMaxLengthInInches)]
        public string Crash4 { get; set; }

        [MaxLength(NotesMaxLength)]
        public string Notes { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public int CategoryId { get; set; }

        public Categories Category { get; set; }
    }
}