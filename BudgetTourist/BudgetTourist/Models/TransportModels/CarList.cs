namespace BudgetTourist.Models.TransportModels
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    using BudgetTourist.TransportContracts.Contracts;

    public class CarList : List<IVehicles>
    {
        public CarList()
        {
            Add(new Automobile("Audi A4", 2008, 100));
            Add(new Automobile("Audi A8", 2010, 120));
            Add(new Automobile("Alfa Romeo 166", 2013, 55));
            Add(new Automobile("Fiat Punto", 2013, 90));
            Add(new Automobile("Sitroen Xantia", 2008, 90));
            Add(new Automobile("Sitroen Berlingo", 2008, 90));
            Add(new Automobile("Peugeot Partner", 2013, 55));
            Add(new Jeep("Audi Q3", 2015, 170));
            Add(new Jeep("Audi Q5", 2015, 180));
            Add(new Jeep("Audi Q7", 2016, 200));
            Add(new Jeep("Acura Mdx", 2013, 140));
            Add(new MotorCykle("Bmw C", 2002, 80));
            Add(new MotorCykle("Laverda Formula 650", 2008, 90));
            Add(new Bicycle("Relay Nepal", 2002, 15));
            Add(new Bicycle("BMX S4", 2009, 20));
            Add(new Bicycle("Aragon 18", 2009, 20));
        }

        /// <summary>
        /// Returns colection of all available cars
        /// </summary>
        public string GetCars(VehiclesType type)
        {
            var sortedList = this.Where(x => x.Type == type).OrderBy(x => x.Model).ToList();

            var sb = new StringBuilder();

            foreach (var vehcle in sortedList)
            {
                sb.AppendLine(vehcle.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Calculate price per rent a car for given time.
        /// </summary>
        public decimal GetPrceOfReservedCar(IVehicles car, DateTime start, DateTime end )
        {
            TimeSpan ts = end - start;
            int differenceInDays = ts.Days;
            return car.PricePerDay * differenceInDays;
        }
    }
}
