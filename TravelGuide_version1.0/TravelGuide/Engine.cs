using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelGuide
{
    public static class Engine
    {
        public static void Run ()
        {
            #region Test reding counties from file
            //Tetsting reading country from file
            //Country country = new Country();
            //var listOfCountries = country.GetCountry();

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

            #region Test Windows Forms Show
            //Diplay -- Print Dialog Form
            GuideForm form = new GuideForm();
            form.ShowDialog();
            #endregion


        }
    }
}
