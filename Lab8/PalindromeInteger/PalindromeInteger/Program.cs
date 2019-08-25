/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		8
*/

using System;

namespace PalindromeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // get value
            Console.Write("Entered value: ");
            int n = int.Parse(Console.ReadLine());
            // print judgement
            Console.Write("Judgment: ");
            if (isPalindrome(n)) // if palindrome is true
            {
                Console.WriteLine("Palindrome");
            }else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        static int reverse (int number) // reverse number
        {
            string tempnumber = number.ToString(); // stor enumber as string
            string result = null;
            for (int i = 1; i <= tempnumber.Length; i++) // reverse string
            {
                result += tempnumber[tempnumber.Length - i]; // store reversed into result
            }
            return int.Parse(result); // convert result to int
        }

        static bool isPalindrome (int number) // check if palindrome
        {
            if (number == reverse(number)) // check if number is same as reversed
            {
                return true;
            }else // not palindrome
            {
                return false;
            }
        }
    }
}
