/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		6
*/

using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print even numbers
            Console.Write("Even numbers between 50 and 100: ");
            for (int i = 50; i <= 100; i++)
            {
                if (i % 2 == 0) // check if even
                {
                    Console.Write(i);
                    if (i != 100) // not last number scenario
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(); // spacing
            // Print odd numbers
            Console.Write("Odd numbers between 50 and 100: ");
            for (int i = 50; i < 100; i++)
            {
                if (i % 2 == 1) // check if odd
                {
                    Console.Write(i);
                    if (i != 99) // not last number scenario
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
