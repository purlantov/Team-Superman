using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTourist.Enums;
using BudgetTourist.Contarcts;

namespace BudgetTourist.Activities
{
    public class NightLife : Sightseeing, IActivities
    {
        private MusicType musicType;

        public NightLife(string name, IsPaid isPaid, double price, string location, MusicType musicType) : 
            base(name, isPaid, price, location)
        {
            this.musicType = musicType;
        }

        public MusicType MusicType { get; protected set; }
    }
}
