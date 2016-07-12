namespace BudgetTourist.Contracts.FoodContracts
{
    using FoodEnums.Enum;
    public interface IDrink : IConsumable
    {
        DrinkType DrinkType { get; }     
    }
}