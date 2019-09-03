using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an amount in USD: $");
            float USD = float.Parse(Console.ReadLine());
            Console.WriteLine("You have " + USD * 9240 + " Guinean Francs");
        }
    }
}
