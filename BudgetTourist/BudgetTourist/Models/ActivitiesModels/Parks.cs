using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
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
