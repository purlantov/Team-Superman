namespace BudgetTourist.Contarcts
{
    public interface IActivities
    {
         string Name { get; }
         double Price { get; }
         string Location { get; }

        double Pay(double money);
    }
}
