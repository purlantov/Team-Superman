namespace BudgetTourist.Models.HousingModels
{
    using Contracts;
    using Common;
    using HousingContracts.Contracts;
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
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name can not be null or empty!");
                this.name = value;
            }
        }
        public string Location
        {
            get { return this.location; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Location can not be null or empty!");
                this.location = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set
            {
                Validator.CheckIfLessThenZero(value, "Price can not be less then zero!");
                this.price = value;
            }
        }
        #endregion
        public string ParkingSpace
        {
            get { return this.parkingSpace; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Parking space can not be null or empty!");
                this.parkingSpace = value;
            }
        }
    }
}
