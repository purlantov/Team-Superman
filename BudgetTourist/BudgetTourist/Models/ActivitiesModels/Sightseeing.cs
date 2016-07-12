using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{
    public abstract class Sightseeing : ActivitiesAbstr, IActivities
    {
        //private IsPaid isPaid;
        //private string location;
        //private string name;
        //private double price;

        public Sightseeing(string name, IsPaid isPaid, double price, string location) 
            : base(name, price, location)
        {
            this.Name = name;
            this.IsPaid = isPaid;
            this.Price = price;
            this.Location = location;
        }

        public IsPaid IsPaid { get; protected set; }
    }
}
