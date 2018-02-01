using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double CostTotal = 0;
            Console.WriteLine("Welcome to the cafe");
            Console.WriteLine("What would you like to order?");
            Console.WriteLine("Your Options are: \n1. Foods\n2. Drinks");
            string OrderOption_1 = Console.ReadLine();
            if (OrderOption_1 == "1")
            {
                var foodBanana = new banana();
                var foodPorridge = new PorridgeFood();
                Console.WriteLine("Available are\n1." + "Banana" + "\n2." + foodPorridge.name);
                string ChoiceFood = Console.ReadLine();
                if (ChoiceFood == "1")
                {
                    CostTotal = foodBanana.Order(CostTotal);
                }
            }
        }

    }
}
