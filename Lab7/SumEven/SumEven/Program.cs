/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		7
*/

using System;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do // get value between 20 and 60 from user
            {
                Console.Write("Enter number (20-60): ");
                n = int.Parse(Console.ReadLine());
                Console.Clear(); // fresh screen
            } while (n < 20 || n > 60); // invalid input case
            Console.WriteLine("Entered value: " + n);
            int sum = 0;
            for (int i = 2; i <= n; i++) // add even numbers to "sum" variable
            {
                if (i % 2 == 0) // is even
                {
                    sum += i; // add to "sum"
                }
            }
            Console.WriteLine("Sum of even numbers between 2 and " + n + " is " + sum);
        }
    }
}
