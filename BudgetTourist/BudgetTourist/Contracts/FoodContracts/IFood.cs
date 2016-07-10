namespace BudgetTourist.Contracts.FoodContracts
{
    using FoodEnums.Enum;
    public interface IFood : IConsumable
    {
        DishType DishType { get; }
    }
}