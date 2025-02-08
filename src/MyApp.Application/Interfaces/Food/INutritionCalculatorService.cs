using MyApp.Application.DTOs.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Interfaces.Food
{
    public interface INutritionCalculatorService
    {
        string CalculateCalories(RecipeDto recipe);
        decimal ConvertToCalories(IngredientDto ingredient);
        string CalculateProtein(RecipeDto recipe);
        decimal ConvertToProtein(IngredientDto ingredient);
        string CalculateCarbohydrates(RecipeDto recipe);
        decimal ConvertToCarbohydrates(IngredientDto ingredient);
        string CalculateFat(RecipeDto recipe);
        decimal ConvertToFat(IngredientDto ingredient);
    }
}
