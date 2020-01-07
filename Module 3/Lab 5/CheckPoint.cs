/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		5
*/

using System;

namespace CheckPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X-coordinate is ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y-coordinate is ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("(" + x + ", " + y + ") is ");
            if (x == 0)
            {
                if (y == 0)
                {
                    Console.Write("the origin point.");
                }else
                {
                    Console.Write("on the y-axis.");
                }
            }else if (y == 0)
            {
                Console.Write("on the x-axis.");
            }
            else
            {
                Console.Write("in the ");
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.Write("first quadrant.");
                    }else
                    {
                        Console.Write("fourth quadrant.");
                    }
                }else if (y > 0)
                {
                    Console.Write("seecond quadrant.");
                }else
                {
                    Console.Write("third quadrant.");
                }
            }
        }
    }
}
