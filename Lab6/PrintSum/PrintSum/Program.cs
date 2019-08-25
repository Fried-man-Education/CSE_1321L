/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		6
*/

using System;

namespace PrintSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // input
            do // take input until correct
            {
                Console.Write("Enter value (1-100): ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Invalid Input. Try again."); // invalid input response
                }
            } while (n < 1 || n > 100); // boundaries
            Console.Clear(); // fresh console for output
            Console.WriteLine("You entered: " + n);
            int sum = 0;
            for (int i = 1; i <= n; i++) // add numbers to "sum" variable
            {
                sum += i;
            }
            Console.WriteLine("Sum of values: " + sum);
        }
    }
}
