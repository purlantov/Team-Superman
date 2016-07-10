namespace BudgetTourist.Activities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enums;
    public class Event : ActivitiesAbstr
    {
        private DateTime startTime;

        public Event(string name, double price, string location, DateTime startTime, EnumEventType type) : base(name, price, location)
        {
            this.StartTime = startTime;
            this.Type = type;
        }

        public EnumEventType Type { get; private set; }

        public DateTime StartTime { get; private set; }
    }
}
