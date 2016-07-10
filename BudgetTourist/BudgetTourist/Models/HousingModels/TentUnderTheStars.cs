namespace BudgetTourist.Models.HousingModels
{
    using Contracts;
    using HousingContracts.Contracts;

    public class TentUnderTheStars : Housing, ITentUnderTheStars     // that's going to be the ultimate option for all hardcore tourists out there...
    {
        public TentUnderTheStars(string name, string location, decimal price, string parkingSpace, int numberOfCompartments)
            : base(name, location, price, parkingSpace)
        {
            this.Name = name;
            this.Location = location;
            this.Price = price;  // the price will be $0 or close to $0, so the tourists will have more money for alcohol and other fun stuff... 
            this.ParkingSpace = parkingSpace;
            this.NumberOfCompartments = numberOfCompartments;
        }

        public int NumberOfCompartments { get; private set; }
    }
}
