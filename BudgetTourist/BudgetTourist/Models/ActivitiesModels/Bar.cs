using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{
    public class Bar : NightLife, IActivities
    {
        public Bar(string name, IsPaid isPaid, double price, string location, MusicType musicType) : base(name, isPaid, price, location, musicType)
        {
        }
    }
}
