namespace BudgetTourist.Contracts.FoodContracts
{
    public interface IConsumable
    {
        string Name { get; }
        double Price { get; }
        double PortionSize { get; }
    }
}
