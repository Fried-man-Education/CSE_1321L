using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.Write("Entered number: ");
            int n = int.Parse(Console.ReadLine());
            // calculation
            int result = 0;
            for (int i = 1; i <= 1000; i *= 10) // iterate by times 10 until 4 digits reached
            {
                result += (n % (i * 10) - n % i) / i; // add value of first x digits minus x-1 digits
            }
            // output
            Console.WriteLine("Sum of digits: " + result);
        }
    }
}
