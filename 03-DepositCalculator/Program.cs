using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double amount = deposit + term * ((deposit * interestRate * 0.01) / 12);
            Console.WriteLine(amount);
        }
    }
}
