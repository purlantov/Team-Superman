using ProjectFood.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFood.Contracts
{
    public interface IFood : IConsumable
    {      
        DishType DishType { get; }
    }
}