using ProjectFood.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFood.Models
{
    public class Order
    {
        IEnumerable<IConsumable> orderList { get; set; }
        double totalPrice { get; set; }
    }
}
