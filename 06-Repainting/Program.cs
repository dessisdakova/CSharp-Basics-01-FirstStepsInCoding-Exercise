using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int diluentQuantity = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double materialsTotal = nylonQuantity * 1.50 + paintQuantity * 14.50 + diluentQuantity * 5.00 + (paintQuantity * 14.50) * 0.10 + 2 * 1.50 + 0.40;
            double workTotal = materialsTotal * workingHours * 0.30;

            Console.WriteLine(materialsTotal + workTotal);
        }
    }
}
