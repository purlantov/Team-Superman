﻿namespace TeamsSuperMan
{
    using System;

    public class Jeep : RentACar, IVehicles
    {
        public Jeep(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {
            this.Type = VehiclesType.Jeep;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
