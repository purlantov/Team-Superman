namespace BudgetTourist.Activities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Contarcts;

    public abstract class ActivitiesAbstr : IActivities
    {
        private string name;
        private double price;
        private string location;
       

        public ActivitiesAbstr(string name, double price, string location)
        {
            this.Name = name;
            this.Price = price;
            this.Location = location;
            
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        


        public double Pay(double money)
        {
            return money - price;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(Name + " activity starts at " + " and is located on " + Location
                + " and the price is " + Price + ".");

            return result.ToString();
        }

    }
}
