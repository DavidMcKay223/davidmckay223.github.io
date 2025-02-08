using MyApp.Domain.Enums.Food;
using Newtonsoft.Json;

namespace MyApp.Application.DTOs.Food
{
    public class MealSuggestionDto
    {
        public int MealSuggestionId { get; set; }
        public required string Name { get; set; }
        public MealType MealType { get; set; }
        public required string Description { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        // Navigation Properties
        [JsonIgnore]
        public List<RecipeMealSuggestionDto> RecipeSuggestions { get; set; } = [];

        [JsonIgnore]
        public List<MealSuggestionTagDto> Tags { get; set; } = [];
    }
}
