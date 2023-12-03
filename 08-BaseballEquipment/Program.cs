using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BaseballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double shoes = annualFee - (annualFee * 0.40);
            double set = shoes - (shoes * 0.20);
            double ball = set / 4;
            double accessories = ball / 5;
            Console.WriteLine(shoes + set + ball + accessories + annualFee);
        }
    }
}
