using BudgetTourist.Contarcts;
using BudgetTourist.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTourist.Activities
{
    public class Museum : Sightseeing, IActivities
    {
        private DateTime openingHour;
        private DateTime closingHour;
        private MuseumType museumType;

        public Museum(string name, IsPaid isPaid, double price, string location, DateTime openingHour, DateTime closingHour, MuseumType museumType) 
            : base(name, isPaid, price, location)
        {
            this.Name = name;
            this.IsPaid = isPaid;
            this.Price = price;
            this.Location = location;
            this.openingHour = openingHour;
            this.closingHour = closingHour;
            this.museumType = museumType;
        }

        public DateTime OpeningHour { get; private set; }
        public DateTime ClosingHour { get; private set; }
        public MuseumType MuseumType { get; private set; }
    }
}
