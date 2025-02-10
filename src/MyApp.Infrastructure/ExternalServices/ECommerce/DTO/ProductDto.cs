namespace MyApp.Infrastructure.ExternalServices.ECommerce.DTO
{
    internal class ProductDto
    {
        public int id { get; set; }
        public string? title { get; set; }
        public double price { get; set; }
        public string? description { get; set; }
        public string? category { get; set; }
        public string? image { get; set; }
        public RatingDto? rating { get; set; }
    }
}
