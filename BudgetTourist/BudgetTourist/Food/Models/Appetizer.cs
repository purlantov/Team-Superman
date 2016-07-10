using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectFood.Enums;

namespace ProjectFood.Models
{
    public class Appetizer : Food
    {
        public Appetizer(string dishName, DishType dishType, double portionSize, double price) : base(dishName, dishType, portionSize, price)
        {
        }
    }
}