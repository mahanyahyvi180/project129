using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 1000;
            double rate = 0.05;

            Console.WriteLine("year Amount on deposite");

            for (int year = 1; year <= 10; ++year)
            {
                decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));

                Console.WriteLine($"{year,4}{amount,20:C}");
                Console.ReadLine();
            }
        }
    }
}
