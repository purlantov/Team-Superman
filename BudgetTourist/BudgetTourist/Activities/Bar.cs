using BudgetTourist.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTourist.Enums;

namespace BudgetTourist.Activities
{
    public class Bar : NightLife, IActivities
    {
        public Bar(string name, IsPaid isPaid, double price, string location, MusicType musicType) : base(name, isPaid, price, location, musicType)
        {
        }
    }
}
