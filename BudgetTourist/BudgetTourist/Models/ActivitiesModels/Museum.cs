using BudgetTourist.Activities.Enums;
using BudgetTourist.Contarcts.ActivitiesContracts;
using System;


namespace BudgetTourist.Models.ActivitiesModels
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
            this.OpeningHour = openingHour;
            this.ClosingHour = closingHour;
            this.MuseumType = museumType;
        }

        public DateTime OpeningHour { get; private set; }
        public DateTime ClosingHour { get; private set; }
        public MuseumType MuseumType { get; private set; }
    }
}
