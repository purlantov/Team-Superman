namespace BudgetTourist.HousingContracts.Contracts
{
    public interface IHousing
    {
        string Name { get; }   // name of the place

        string Location { get; }   // where is the place located

        decimal Price { get; }   

        string ParkingSpace { get; }  
    }
}
