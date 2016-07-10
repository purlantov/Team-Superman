using ProjectFood.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectFood.Contracts;

namespace ProjectFood.Models
{
    public class Menu : IMenu
    {
        private ICollection<IFood> foodList;
        private ICollection<IDrink> drinkList;

        
        public ICollection<IDrink> DrinkList
        {
            get
            {
                return new List<IDrink>(this.drinkList);
            }
            private set
            {

            }
        }

        public ICollection<IFood> FoodList
        {
            get
            {
                return new List<IFood>(this.foodList);
            }
            private set
            {

            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}