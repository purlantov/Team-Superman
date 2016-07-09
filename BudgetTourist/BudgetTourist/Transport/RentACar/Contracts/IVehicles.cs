namespace TeamsSuperMan
{
    public interface IVehicles
    {
        string Model { get; }
        int Year { get; }
        decimal PricePerDay { get; }
    }
}
