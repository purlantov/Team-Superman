using BudgetTourist.FoodEnums.Enum;
using System.Collections;

namespace BudgetTourist.Models.FoodModels
{
    public class Dessert : Food
    {
        public Dessert(string dishName, DishType dishType, double portionSize, double price) : base(dishName, dishType, portionSize, price)
        {
        }
    }
}