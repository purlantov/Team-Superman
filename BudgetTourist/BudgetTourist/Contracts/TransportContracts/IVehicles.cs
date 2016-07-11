namespace BudgetTourist.TransportContracts.Contracts
{
    using BudgetTourist.TransportEnums.Enum;

    public interface IVehicles
    {
        string Model { get; }
        int Year { get; }
        decimal PricePerDay { get; }
        VehiclesType Type { get; }

    }
}
