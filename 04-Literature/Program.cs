using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Literature
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageNumber = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());
            int total = (pageNumber / pagePerHour) / daysForReading;
            Console.WriteLine(total);
        }
    }
}
