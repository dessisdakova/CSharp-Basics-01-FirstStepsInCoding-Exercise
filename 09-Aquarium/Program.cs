using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeAq = (lenght * width * height) *0.001;
            double volumeMisc = volumeAq * (1 -percent * 0.01);
            Console.WriteLine(volumeMisc);
            

        }
    }
}
