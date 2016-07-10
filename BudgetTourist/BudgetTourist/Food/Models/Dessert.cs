using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectFood.Enums;

namespace ProjectFood.Models
{
    public class Dessert : Food
    {
        public Dessert(string dishName, DishType dishType, double portionSize, double price) : base(dishName, dishType, portionSize, price)
        {
        }
    }
}