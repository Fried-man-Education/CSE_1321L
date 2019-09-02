using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the flight distance: ");
            int distance = int.Parse(Console.ReadLine());
            Console.Write("Enter the current cost of jet fuel: ");
            float costFuel = float.Parse(Console.ReadLine());
            Console.WriteLine("The flight will cost $" + distance * costFuel * 5 + " in jet fuel");
            Console.Write("Enter the number of passengers: ");
            int passengers = int.Parse(Console.ReadLine());
            Console.Write("Enter the average cost of a ticket: ");
            int costTicket = int.Parse(Console.ReadLine());
            Console.WriteLine("You will make a profit of $" + (passengers * costTicket - distance * costFuel * 5));
            Console.WriteLine("You averaged " + passengers / 5 + " miles per person per gallon!");
        }
    }
}
