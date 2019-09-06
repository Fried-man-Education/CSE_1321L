using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter an amount in USD: $");
            float USD = float.Parse(Console.ReadLine());
            // convert and output
            Console.WriteLine("You have " + USD * 9240 + " Guinean Francs");
        }
    }
}
