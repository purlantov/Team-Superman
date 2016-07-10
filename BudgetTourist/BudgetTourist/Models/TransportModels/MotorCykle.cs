namespace BudgetTourist.Models.TransportModels
{
    using HousingContracts.Contracts;
    using System;

    public class MotorCykle : RentACar, IVehicles
    {
        public MotorCykle(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
