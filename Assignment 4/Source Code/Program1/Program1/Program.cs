using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            float xPos, yPos, xVel, yVel;
            Console.Write("Enter the starting X position: ");
            xPos = float.Parse(Console.ReadLine());
            Console.Write("Enter the starting Y position: ");
            yPos = float.Parse(Console.ReadLine());
            Console.Write("Enter the starting X veloicty: ");
            xVel = float.Parse(Console.ReadLine());
            Console.Write("Enter the starting Y velocity: ");
            yVel = float.Parse(Console.ReadLine());
            while (xPos < 100 && xPos > 0)
            {
                Console.WriteLine("X:" + Math.Round(xPos, 1) + "  Y:" + Math.Round(yPos, 1));
                xPos += xVel;
                yPos += yVel;
            }
            Console.WriteLine("X:" + Math.Round(xPos, 1) + "  Y:" + Math.Round(yPos, 1));
        }
    }
}
