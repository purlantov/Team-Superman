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

        public override string ToString()
        {
            return string.Format("Name: {0} Price: {1}", this.Name, this.Price);
        }
    }
}
