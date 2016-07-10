namespace BudgetTourist.Models.HousingModels
{
    using Contracts;
    using HousingContracts.Contracts;
    public class RentApartment : Housing, IRentApartment
    {
        public RentApartment(string name, string location, decimal price, string parkingSpace, int numberOfBedrooms)
            : base(name, location, price, parkingSpace)
        {
            this.Name = name;
            this.Location = location;
            this.Price = price;
            this.ParkingSpace = parkingSpace;
            this.NumberOfBedrooms = numberOfBedrooms;
        }

        public int NumberOfBedrooms { get; private set; }
    }
}
