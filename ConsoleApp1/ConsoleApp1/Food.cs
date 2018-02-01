using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Food
    {
        public string name;
        public double cost;
        
        public virtual double Order (double CostTotal)
        {
            Console.WriteLine(name + " costs :" + cost);
            Console.WriteLine("Do you wish to buy it?\n1.Yes\n2.No");
            string ChoiceFoodBanana = Console.ReadLine();
            if (ChoiceFoodBanana == "1")
            {
                Console.WriteLine(name + " has been added to your cart");
                var costAdded = CostTotal + cost;
                return costAdded;
            }
            if (ChoiceFoodBanana == "2")
            {
                Console.WriteLine("Order cancelled");
                return CostTotal;
            }
            return CostTotal;
        }
    }
}
