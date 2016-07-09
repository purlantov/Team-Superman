namespace BudgetTourist.Housing
{
    using System;
    using Contracts;
    public class Hotel : Housing, IHotel
    {
        #region Constructors
        public Hotel(string name, string location, decimal price, string parkingSpace, double numberOfStars, int numberOfRooms, string breakfast)
            : base(name, location, price, parkingSpace)
        {
            this.Name = name;
            this.NumberOfRooms = numberOfRooms;
            this.Location = location;
            this.Price = price;
            this.ParkingSpace = parkingSpace;
            this.NumberOfStars = numberOfStars;
            this.NumberOfRooms = numberOfRooms;
            this.Breakfast = breakfast;
           
        }
        #endregion

        #region Properties
        public double NumberOfStars { get; private set; }
        public int NumberOfRooms { get; private set; }
        public string Breakfast { get; private set; }


        #endregion

    }
}
