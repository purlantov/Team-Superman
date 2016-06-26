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
            //Tetsting reading country from file
            Country country = new Country();
            country.GetCountry();

            //Diplay -- Print Dialog Form
            GuideForm form = new GuideForm();
            form.ShowDialog();
        }
    }
}
