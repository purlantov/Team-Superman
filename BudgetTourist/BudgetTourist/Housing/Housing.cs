namespace BudgetTourist.Housing
{
    using Contracts;
    public abstract class Housing : IHousing   // all housing types will derive from this abstract class Housing
    {
        #region Fields
        private string name;

        private string location;

        private decimal price;

        private string parkingSpace;
        #endregion

        #region Constuctors
        public Housing(string name, string location, decimal price, string parkingSpace)
        {
            this.Name = name;
            this.Location = location;
            this.Price = price;
            this.ParkingSpace = parkingSpace;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        #endregion
        public string ParkingSpace
        {
            get { return this.parkingSpace; }
            set { this.parkingSpace = value; }
        }
    }
}
