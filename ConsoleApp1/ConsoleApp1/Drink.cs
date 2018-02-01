using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Drink
    {
        public string name;
        public double cost;

        public virtual double Order(double CostTotal)
        {
            Console.WriteLine("This item has been added to your cart");
            var CostAdded = CostTotal + cost;
            Console.WriteLine("Your current cart value is " + CostTotal);
            return CostTotal;
        }
    }
}
