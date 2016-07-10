using BudgetTourist.FoodEnums.Enum;

namespace BudgetTourist.Models.FoodModels
{
    public class Appetizer : Food
    {
        public Appetizer(string dishName, DishType dishType, double portionSize, double price) : base(dishName, dishType, portionSize, price)
        {
        }
    }
}