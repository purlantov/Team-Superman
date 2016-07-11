namespace BudgetTourist.TransportContracts.Contracts
{
    public interface IVehicles
    {
        string Model { get; }
        int Year { get; }
        decimal PricePerDay { get; }
        VehiclesType Type { get; }

    }
}
