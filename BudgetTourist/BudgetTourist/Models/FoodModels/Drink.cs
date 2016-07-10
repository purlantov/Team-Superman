namespace BudgetTourist.Models.FoodModels
{
    using Contracts.FoodContracts;
    using FoodEnums.Enum;
    using System.Text;
    public class Drink : IDrink
    {
        private string name;
        private DrinkType drinkType;
        private double portionSize;
        private double price;

        public Drink(string drinkName, DrinkType drinkType, double portionSize, double price)
        {
            this.Name = drinkName;
            this.DrinkType = drinkType;
            this.PortionSize = portionSize;
            this.Price = price;
        }

        public string Name
        {
            get  {   return this.name; }
            private set
            {
                this.name = value;
            }
        }

        public DrinkType DrinkType
        {
            get  { return this.drinkType; }
            private set
            {
                this.drinkType = value;
            }
        }

        public double PortionSize
        {
            get   { return this.portionSize;  }
            private set
            {
                this.portionSize = value;
            }
        }

        public double Price
        {
            get   { return this.price; }
            private set
            {
                this.price = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Dish name: {0}", this.Name));
            sb.AppendLine(string.Format("Dish kind: {0}", this.GetType().Name));
            sb.AppendLine(string.Format("Dish type: {0}", this.DrinkType));
            sb.AppendLine(string.Format("Portion Size: {0:F3} kgs", this.PortionSize));
            sb.Append(string.Format("Price {0:F2} levs", this.Price));
            sb.AppendLine();

            return sb.ToString();

        }
    }
}