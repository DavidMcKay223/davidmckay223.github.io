namespace MyApp.Application.DTOs.Food
{
    public class RecipeMealSuggestionDto
    {
        public int RecipeId { get; set; }
        public int MealSuggestionId { get; set; }

        // Navigation Properties
        public RecipeDto? Recipe { get; set; }
        public MealSuggestionDto? MealSuggestion { get; set; }
    }
}
