namespace BudgetTourist.Models.TransportModels
{
    using System;

    using BudgetTourist.TransportContracts.Contracts;

    public class Bicycle : RentACar, IVehicles
    {
        public Bicycle(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {
            this.Type = VehiclesType.Bicycle;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
