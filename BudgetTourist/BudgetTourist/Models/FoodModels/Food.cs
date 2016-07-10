using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectFood.Enums;
using ProjectFood.Contracts;

namespace ProjectFood.Models
{
    public abstract class Food : IFood
    {
        private string name;
        private DishType dishType;
        private double portionSize;
        private double price;

        public Food(string dishName , DishType dishType,double portionSize,double price )
        {
            this.name = dishName;
            this.DishType = dishType;
            this.PortionSize = portionSize;
            this.Price = price;
        }
        
        public virtual string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException("Invalid dish name!");
                }
                this.name = value;
            }
        }

        public virtual DishType DishType
        {
            get  { return this.dishType; }
            set
            {
                this.dishType = value;
            }
        }

        public virtual double PortionSize
        {
            get  { return this.portionSize; }
            set
            {
                this.portionSize = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The price must be possitive!");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Dish name: {0}", this.Name));
            sb.AppendLine(string.Format("Dish kind: {0}",this.GetType().Name));
            sb.AppendLine(string.Format("Dish type: {0}", this.DishType));
            sb.AppendLine(string.Format("Portion Size: {0:F3} kgs", this.PortionSize));
            sb.Append(string.Format("Price {0:F2} levs", this.Price));
            sb.AppendLine();
            return sb.ToString();
            
        }
    }
}