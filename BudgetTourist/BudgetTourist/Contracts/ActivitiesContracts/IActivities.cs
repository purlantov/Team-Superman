namespace BudgetTourist.Contarcts.ActivitiesContracts
{
    public interface IActivities
    {
         string Name { get; }
         double Price { get; }
         string Location { get; }

        double Pay(double money);
    }
}
