using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{
    public class Club : NightLife, IActivities
    {
        private string extras;

        public Club(string name, IsPaid isPaid, double price, string location, MusicType musicType, string extras) :
            base(name, isPaid, price, location, musicType)
        {
            this.Extras = extras;
        }

        public string Extras { get; protected set; }
    }
}
