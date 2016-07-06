using ProjectFood.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFood.Models
{
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