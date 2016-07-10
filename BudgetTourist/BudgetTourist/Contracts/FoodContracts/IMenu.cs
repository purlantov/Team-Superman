namespace BudgetTourist.Contracts.FoodContracts
{
    using System.Collections.Generic;
    
    public interface IMenu
    {
        ICollection<IFood> FoodList { get; }
        ICollection<IDrink> DrinkList { get; }
    }
}