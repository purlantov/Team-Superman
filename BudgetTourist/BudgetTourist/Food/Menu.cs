namespace BudgetTourist.Food
{
    using System.Collections.Generic;

    using Contracts;

    public class FoodMenu : IMenu
    {
        private IEnumerable<IFood> menyList;

        public IEnumerable<IFood> MenuList
        {
            get
            {
                return new List<IFood>(this.menyList);
            }
            private set
            {

            }
        }
    }
}
