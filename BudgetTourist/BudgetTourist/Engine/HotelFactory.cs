

namespace BudgetTourist.Engines
{
    using BudgetTourist.HousingContracts.Contracts;
using BudgetTourist.Models.HousingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class HotelFactory
    {
        public static ICollection<IHousing> GetHotels()
        {
            List<IHousing> housingList = new List<IHousing>();
            housingList.Add(new Hotel("Balkan", "Center", 171, "Yes", 5, 15, "Yes"));
            housingList.Add(new Hotel("Novotel", "Tsarigradsko Shosse Blvd", 115, "Yes", 4, 3, "Yes"));
            housingList.Add(new Hotel("Dream", "Alexander Malinov", 92, "Yes", 3, 12, "Yes"));

            return housingList;
        }

        public override string ToString()
        {
            ICollection<IHousing> list = GetHotels();
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
