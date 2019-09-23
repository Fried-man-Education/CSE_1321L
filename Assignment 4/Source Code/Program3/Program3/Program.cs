using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            double init, add, year, rate;
            Console.Write("Enter the principle: ");
            init = double.Parse(Console.ReadLine());
            Console.Write("Enter the annual addition: ");
            add = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of years to grow: ");
            year = double.Parse(Console.ReadLine());
            Console.Write("Enter the interest rate as a percentage: ");
            rate = double.Parse(Console.ReadLine());
            for (int i = 0; i <= year; i++)
            {
                Console.WriteLine("Year " + i + ": $" + Math.Round(init, 2));
                init += add;
                init *= 1 + (rate / 100);
            }
        }
    }
}
