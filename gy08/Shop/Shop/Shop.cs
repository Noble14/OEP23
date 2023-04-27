using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        public Department food;
        public Department tech;

        public Shop(string food, string tech)
        {
            this.food = new Department(food);
            this.tech = new Department(tech);
        }
    }
}
