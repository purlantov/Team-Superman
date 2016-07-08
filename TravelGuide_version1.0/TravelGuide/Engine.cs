namespace TravelGuide
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Engine
    {
        public static void Run()
        {
            //Tetsting reading country from file
            Country country = new Country();
            var listOfCountries = country.GetCountry();

            #region Test reding counties from file
            //foreach (var item in listOfCountries)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(new string('=', 15));

            //var list = listOfCountries.Select(x => x.Name == "ASIA");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); //returns TRUE or FALSE
            //}
            #endregion

            #region Test Windows Forms
            //Diplay -- Print Dialog Form
            GuideForm form = new GuideForm();
            form.ShowDialog();
            //form.PrintContinent("asia");
            //form.PrintContinent("europe");
            
            #endregion


        }
    }
}
