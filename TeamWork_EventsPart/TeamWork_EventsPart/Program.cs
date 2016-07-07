using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork_EventsPart
{
    class Program
    {
        static void Main(string[] args)
        {
            Event nightOfMuseums = new Event("Night of the Museums", 0.00, "Plovdiv", new DateTime(2016, 07, 25), EnumEventType.cultural);

            Console.WriteLine(nightOfMuseums.ToString());
        }
    }
}
