using System.ComponentModel.DataAnnotations.Schema;

namespace SoundAndDance_v2.Data.Models
{
    public class Price
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal TotalPrice { get; set; }
    }
}