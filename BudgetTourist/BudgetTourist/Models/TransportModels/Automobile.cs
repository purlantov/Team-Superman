namespace TeamsSuperMan
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Automobile : RentACar, IVehicles
    {
        public Automobile(string model, int year, decimal priceForDay) : base(model, year, priceForDay)
        {
            this.Type = VehiclesType.Automobile;
        }

        public override string ToString()
        {
            //return string.Format("MOdel: {0} Year: {1} Price: {2}");
            return base.ToString();
        }
    }
}
