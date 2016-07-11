namespace BudgetTourist.Models.TransportModels
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using BudgetTourist.TransportEnums.Enum;
    using BudgetTourist.TransportContracts.Contracts;

    public class Automobile : RentACar, IVehicles
    {
        public Automobile(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {
            this.Type = VehiclesType.Automobile;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
