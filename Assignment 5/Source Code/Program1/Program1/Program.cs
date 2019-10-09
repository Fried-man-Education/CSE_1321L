using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter hourly wage: ");
            float wage = float.Parse(Console.ReadLine());
            Console.Write("Enter your hours per week: ");
            float hours = float.Parse(Console.ReadLine());
            // output data
            Console.WriteLine("You will earn $" + earnings(wage, hours) + " per year");
            Console.WriteLine("You will pay $" + tax(wage, hours) + " in Social Security tax");
        }

        public static float earnings(float wage, float hours) // calculates earnings
        {
            return wage * hours * 52;
        }

        public static float tax(float wage, float hours) // calculates tax amount
        {
            return wage * hours * 52 * .062f;
        }
    }
}
