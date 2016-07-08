using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFood
{
    public interface IFood
    {
        string DishName { get;}
        double Price { get;}
    }
}