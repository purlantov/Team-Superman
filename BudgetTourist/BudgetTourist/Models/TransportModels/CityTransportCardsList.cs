namespace BudgetTourist.Models.TransportModels
{
    using System.Text;
    using System.Collections.Generic;

    using BudgetTourist.TransportContracts.Contracts;

    public class CityTransportCardsList : List<ICartable>
    {
        public CityTransportCardsList()
        {
            Add(new CityTransportCart("One days card for all transports", 4));
            Add(new CityTransportCart("One days card for metro", 3));
            Add(new CityTransportCart("Three days card for all transports", 10));
            Add(new CityTransportCart("Three days card for metro", 10));
        }

        public string GetCarts()
        {
            var sb = new StringBuilder();

            foreach (var cart in this)
            {
                sb.AppendLine(cart.ToString());
            }

            return sb.ToString();
        }
    }
}
