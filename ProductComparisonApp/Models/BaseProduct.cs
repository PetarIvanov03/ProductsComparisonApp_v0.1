namespace ProductComparisonApp.Models
{
    public abstract class BaseProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }
        public string ImageUrl { get; set; }
    }
}
