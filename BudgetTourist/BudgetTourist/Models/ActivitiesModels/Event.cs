namespace BudgetTourist.Models.ActivitiesModels
{
    using Activities.Enums;
    using System;

    public class Event : ActivitiesAbstr
    {
        private DateTime startTime;

        public Event(string name, double price, string location, DateTime startTime, EnumEventType type) : 
            base(name, price, location)
        {
            this.StartTime = startTime;
            this.Type = type;
        }

        public EnumEventType Type { get; private set; }

        public DateTime StartTime { get; private set; }
    }
}
