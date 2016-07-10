using BudgetTourist.Contarcts;
using BudgetTourist.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTourist.Activities
{
    public class Parks : Sightseeing, IActivities
    {
        public Parks(string name, IsPaid isPaid, double price, string location) : base(name, isPaid, price, location)
        {
            this.Name = name;
            this.IsPaid = isPaid;
            this.Price = price;
            this.Location = location;
        }
    }
}
