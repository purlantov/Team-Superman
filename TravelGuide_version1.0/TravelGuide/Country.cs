namespace TravelGuide
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Country
    {
        public List<Continent> countryList = new List<Continent>();

        public List<Continent> GetCountry()
        {
            string filePath = "../../Countries.txt";
            string[] str;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.ReadLine() != "END")
                    {
                        str = sr.ReadLine().Split(',');
                        countryList.Add(new Continent { Name = str[0], Country = str[1] });
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return countryList;
        }
    }
}