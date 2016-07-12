namespace BudgetTourist.Models.FoodModels
{
    using BudgetTourist.Contracts.FoodContracts;
    using System.Collections.Generic;

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
            return base.ToString(); // TODO : override!
        }
    }
}