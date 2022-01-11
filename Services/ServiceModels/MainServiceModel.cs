namespace SoundAndDance_v2.Services.ServiceModels
{
    public class MainServiceModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string SerialNumber { get; set; }

        public string Notes { get; set; }

        public int Count { get; set; }

        public int PriceId { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public int CategoryId { get; set; }
    }
}