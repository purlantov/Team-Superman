namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public class Country : Climat
    {
        public Capital Capital { get; set; }
        public string Name { get; private set; }

        //public List<City> MyProperty { get; set; }

        public Country(string name)
        {
            this.Name = name;
        }

        public string[] GetCountry()
        {
            var countriesList = new List<string>();
            var continentsList = new List<string>();
            using (StreamReader sr = new StreamReader("../../Countries.txt"))
            {
                while (sr.ReadLine() != "END")
                {
                    string str = sr.ReadLine().TrimStart(' ');
                    if (str.EndsWith(";"))
                    {
                        //str.Equals(Continents.Africa);
                        continentsList.Add(str);
                    }
                }
            }

            return new string[] { "null" };
        }
    }
}