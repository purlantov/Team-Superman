using ProjectFood.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFood.Cotracts
{
    public interface IMenu
    {
        ICollection<IFood> FoodList { get; }
        ICollection<IDrink> DrinkList { get; }
    }
}