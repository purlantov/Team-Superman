namespace BudgetTourist.Contracts.FoodContracts
{
    using BudgetTourist.Enums.FoodEnums;
    using FoodEnums.Enum;
    public interface IDrink : IConsumable
    {
        
        DrinkType DrinkType { get; }
        
    }
}