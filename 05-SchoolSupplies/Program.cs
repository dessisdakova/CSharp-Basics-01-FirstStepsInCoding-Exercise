using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SchoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int packsOfPens = int.Parse(Console.ReadLine());
            int packsOfMarkers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discountPerc = int.Parse(Console.ReadLine());

            double totalsum = packsOfPens * 5.80 + packsOfMarkers * 7.20 + litersCleaner * 1.20;
            double discount = totalsum * discountPerc * 0.01;
            Console.WriteLine(totalsum - discount);
        }
    }
}
