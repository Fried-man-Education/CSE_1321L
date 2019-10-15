/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		9
*/

using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("You entered: ");
            int n = int.Parse(Console.ReadLine());
            // print answer
            Console.WriteLine("Sum of digits: " + SumDigits(n));
        }

        static int SumDigits (int number) // finds sum of digits
        {
            string temp = number.ToString(); // convert int to string
            int sum = 0;
            for (int i = 0; i < temp.Length; i++) // cycle through chars
            {
                sum += int.Parse(temp[i].ToString()); // store values into sum
            }
            return sum;
        }
    }
}
