namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Continent : Guide
    {
        //    public enum Continents
        //    {
        //        Asia = 1,
        //        Africa = 2,
        //        North_America = 3,
        //        South_America = 4,
        //        Antarctica = 5,
        //        Europe = 6,
        //        Australia = 7
        //    }

        public Continent()
        {

        }

        public Continent(string name)
        {
            this.Name = name;
        }

        public Continent(string name, string country)
            : this(name)
        {
            this.Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, Country);
        }
    }
}