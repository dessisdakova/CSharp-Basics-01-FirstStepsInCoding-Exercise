using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_USDintoBG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter BGN:");
            double bgn = double.Parse(Console.ReadLine());
            double usd = bgn * 1.79549;

            Console.WriteLine(usd);

        }
    }
}
