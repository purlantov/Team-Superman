using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{

    public class Churches : Sightseeing, IActivities
    {
        //private ChurchType churchType;

        public Churches(string name, IsPaid isPaid, double price, string location, ChurchType churchtype) :
            base(name, isPaid, price, location)
        {
            this.IsPaid = isPaid;
            this.ChurchType = churchtype;
        }

        public ChurchType ChurchType { get; set; }



    }
}
