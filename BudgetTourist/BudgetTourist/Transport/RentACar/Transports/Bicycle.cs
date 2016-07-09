namespace TeamsSuperMan
{
    using System;

    public class Bicycle : RentACar, IVehicles
    {
        public Bicycle(string model, int year, decimal priceForDay)
            : base(model, year, priceForDay)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
