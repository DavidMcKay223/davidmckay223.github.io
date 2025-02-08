using Newtonsoft.Json;

namespace MyApp.Application.DTOs.Food
{
    public class StoreSectionDto
    {
        public int StoreSectionId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Navigation Property
        [JsonIgnore]
        public List<FoodItemStoreSectionDto> FoodItems { get; set; } = [];
    }
}
