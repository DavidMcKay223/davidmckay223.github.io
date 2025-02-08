﻿using Newtonsoft.Json;

namespace MyApp.Application.DTOs.Food
{
    public class FoodCategoryDto
    {
        public int FoodCategoryId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Navigation Property
        [JsonIgnore]
        public List<FoodItemDto> FoodItems { get; set; } = [];
    }
}
