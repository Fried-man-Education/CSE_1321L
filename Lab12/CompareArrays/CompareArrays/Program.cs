/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		12
*/

using System;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //get size of array
            Console.WriteLine("Size of array:");
            int[,] Array = new int[2, int.Parse(Console.ReadLine())]; // set size of array
            getInput(Array, 0); // grab values of array 0
            getInput(Array, 1); // grab values of array 1
            Console.Clear(); // fresh screen
            // print outputs
            Console.WriteLine("Array size: " + Array.GetLength(1));
            Console.Write("First array: ");
            printArray(Array, 0); // print values of array 0
            Console.Write("Second array: ");
            printArray(Array, 1); // print values of array 1
            Console.Write("Judgment: ");
            if (Compare(Array)) // if identical
            {
                Console.WriteLine("The arrays are identical");
            }else // not identical
            {
                Console.WriteLine("The arrays are not identical");
            }
        }

        static void getInput(int[,] Array, int n) // ask user for all values in Array[n]
        {
            for (int i = 0; i < Array.GetLength(1); i++)
            {
                Console.WriteLine("Enter value #" + i + " of array #" + n);
                Array[n, i] = int.Parse(Console.ReadLine());
            }
        }

        static void printArray(int[,] Array, int n) // print all values in Array[n]
        {
            for (int i = 0; i < Array.GetLength(1); i++)
            {
                Console.Write(Array[n, i]);
                if (i < Array.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static bool Compare(int[,] Array) // compare both arrays and return verdict
        {
            bool verdict = true;
            for (int i = 0; i < Array.GetLength(1); i++) // go from Array[][0] to Array[][end]
            {
                if (Array[0,i] != Array[1, i]) // check if two values arent the same
                {
                    verdict = false;
                }
            }
            return verdict;
        }
    }
}
