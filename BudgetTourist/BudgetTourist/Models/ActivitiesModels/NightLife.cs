using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;

namespace BudgetTourist.Models.ActivitiesModels
{
    public class NightLife : Sightseeing, IActivities
    {
        //private IsPaid isPaid;
        //private string location;
        //private MusicType musicType;
        //private string name;
        //private double price;

        public NightLife(string name, IsPaid isPaid, double price, string location, MusicType musicType) 
            : base(name, isPaid, price, location)
        {
            this.MusicType = musicType;
        }

        public MusicType MusicType { get; protected set; }
    }
}
