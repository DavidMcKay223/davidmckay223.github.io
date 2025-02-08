﻿namespace MyApp.Application.DTOs.Food
{
    public class PriceHistoryDto
    {
        public int PriceHistoryId { get; set; }
        public int FoodItemId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation Property
        public FoodItemDto? FoodItem { get; set; }
    }
}
