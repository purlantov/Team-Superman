using BudgetTourist.FoodEnums.Enum;
using System.Collections;
using System;

namespace BudgetTourist.Models.FoodModels
{
    public class MainDish : Food
    {
        public MainDish(string dishName, DishType dishType, double portionSize, double price) : base(dishName, dishType, portionSize, price)
        {
        }
        
    }
}