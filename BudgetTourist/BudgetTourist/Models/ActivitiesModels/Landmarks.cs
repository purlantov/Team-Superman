using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{
    public class Landmarks : Sightseeing, IActivities
    {
        public Landmarks(string name, IsPaid isPaid, double price, string location) 
            : base(name, isPaid, price, location)
        {
            this.Name = name;
            this.IsPaid = isPaid;
            this.Price = price;
            this.Location = location;
        }
    }
}
