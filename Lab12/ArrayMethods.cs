/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		12
*/

using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array with length 5 and store random values (1-100)
            Random rnd = new Random();
            int[] arr = new int[5] {rnd.Next(1,101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101) };
            // print output
            Console.Write("Original array: ");
            printArray(arr);
            Console.WriteLine("Max value: " + arrayMax(arr));
            Console.WriteLine("Min value: " + arrayMin(arr));
            Console.Write("Squared array: ");
            arraySquared(arr);
            printArray(arr);
            Console.Write("Reversed array: ");
            arrayReverse(arr);
            printArray(arr);
        }

        static void printArray (int[] arr) // prints array values
        {
            for (int i = 0; i < arr.Length; i++) // iterate through values in arr
            {
                Console.Write(arr[i]); // print value
                if (i < arr.Length - 1) // if not last value
                {
                    Console.Write(", "); // add syntax
                }
            }
            Console.WriteLine(); // end of line
        }

        static int arrayMax(int[] arr) // find max value in array
        {
            int b = arr[0]; // max 
            for(int i = 0,  a; i < arr.Length; i++) // iterate through values in arr
            {
                a = arr[i];
                if (a > b) // new max
                {
                    b = a; // store new max
                }
            }
            return b;
        }

        static int arrayMin(int[] arr) // find min value in array
        {
            int b = arr[0]; // min
            for (int i = 0, a; i < arr.Length; i++) // iterate through values in arr
            {
                a = arr[i];
                if (a < b) // new min
                {
                    b = a; // store new min
                }
            }
            return b;
        }

        static void arraySquared(int[] arr) // square array values
        {
            for (int i = 0; i < arr.Length; i++) // iterate through values in arr
            {
                arr[i] *= arr[i]; // multiply value by itself
            }
        }

        static void arrayReverse(int[] arr) // reverses array
        {
            int[] temp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) // store reversed array in temp
            {
                temp[i] = arr[arr.Length - i - 1];
            }
            for (int i = 0; i < arr.Length; i++) // send temp values to arr
            {
                arr[i] = temp[i];
            }
        }
    }
}
