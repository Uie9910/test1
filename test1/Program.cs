using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_precent = 15;
            int tax_precent = 8;
            var cost = meal_cost + tip_precent + (meal_cost + tip_precent) * tax_precent * 0.01;
            Console.WriteLine("您的用餐費用是:"+ cost);

            Console.ReadLine();
        }
    }
}
