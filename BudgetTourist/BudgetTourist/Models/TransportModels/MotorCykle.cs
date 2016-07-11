namespace BudgetTourist.Models.TransportModels
{
    using System;

    using BudgetTourist.TransportEnums.Enum;
    using BudgetTourist.TransportContracts.Contracts;

    public class MotorCykle : RentACar, IVehicles
    {
        public MotorCykle(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {
            this.Type = VehiclesType.Motorcykle;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
