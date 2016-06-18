namespace TourGuide
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Country : Continent
    {
        public Capital Capital { get; set; }
        public List<City> MyProperty { get; set; }
    }
}