using ProjectFood.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFood.Contracts
{
    public interface IDrink : IConsumable
    {
        
        DrinkType DrinkType { get; }
        
    }
}