namespace TeamsSuperMan
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Automobile : RentACar, IVehicles
    {
        public Automobile(string model, int year, decimal priceForDay) : base(model, year, priceForDay)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
