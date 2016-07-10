using BudgetTourist.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTourist.Enums;

namespace BudgetTourist.Activities
{
    public class Club : NightLife, IActivities
    {
        private string extras;

        public Club(string name, IsPaid isPaid, double price, string location, MusicType musicType, string extras) : base(name, isPaid, price, location, musicType)
        {
            this.Extras = extras;
        }

        public string Extras { get; protected set; }
    }
}
