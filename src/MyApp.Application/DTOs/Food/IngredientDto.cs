using MyApp.Domain.Enums.Food;

namespace MyApp.Application.DTOs.Food
{
    public class IngredientDto
    {
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public int FoodItemId { get; set; }
        public decimal Quantity { get; set; }
        public UnitType Unit { get; set; }

        // Navigation Properties
        public RecipeDto? Recipe { get; set; }
        public FoodItemDto? FoodItem { get; set; }
    }
}
