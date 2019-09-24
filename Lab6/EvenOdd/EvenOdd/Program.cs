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
            printValues(0); // 0 is even
            Console.WriteLine(); // spacing
            // Print odd numbers
            Console.Write("Odd numbers between 50 and 100: ");
            printValues(1); // 1 is odd
        }

        static void printValues (int type) // prints list of values from type
        {
            for (int i = 50; i < 100; i++)
            {
                if (i % 2 == type) // check if same type
                {
                    Console.Write(i);
                    if (i != 99) // not last number scenario
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
