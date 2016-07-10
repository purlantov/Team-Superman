using BudgetTourist.Contracts.FoodContracts;
using System.Collections.Generic;


namespace BudgetTourist.Models.FoodModels
{
    public class Order
    {
        IEnumerable<IConsumable> orderList { get; set; }
        double totalPrice { get; set; }
        // TODO : finish here
    }
}
