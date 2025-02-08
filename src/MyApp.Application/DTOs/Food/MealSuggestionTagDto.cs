using Newtonsoft.Json;

namespace MyApp.Application.DTOs.Food
{
    public class MealSuggestionTagDto
    {
        public int TagId { get; set; }
        public required string TagName { get; set; }

        // Navigation Property
        [JsonIgnore]
        public List<MealSuggestionDto> MealSuggestions { get; set; } = [];
    }
}
