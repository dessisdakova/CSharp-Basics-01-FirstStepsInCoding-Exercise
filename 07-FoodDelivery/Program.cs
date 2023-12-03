using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegMenu = int.Parse(Console.ReadLine());

            double menusTotal = chickenMenu * 10.35 + fishMenu * 12.40 + vegMenu * 8.15;
            double dessert = menusTotal * 0.20;
            Console.WriteLine(menusTotal + dessert + 2.50);
        }
    }
}
