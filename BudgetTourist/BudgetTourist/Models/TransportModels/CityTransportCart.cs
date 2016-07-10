namespace TeamsSuperMan
{
    public class CityTransportCart : ICartable
    {
        public CityTransportCart(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }

        public decimal Price { get; private set; }
    }
}
