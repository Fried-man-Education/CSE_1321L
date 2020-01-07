/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		13
*/

using System;

namespace AddMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3]; // initialize 2d array 3 x 3
            int[,] arr2 = new int[3, 3]; // initialize 2d array 3 x 3
            // user input
            getValues(arr1, 0);
            getValues(arr2, 1);
            // output
            Console.WriteLine("Matrix A:");
            printArray(arr1);
            Console.WriteLine("Matrix B:");
            printArray(arr2);
            Console.WriteLine("A + B:");
            printArray(Addition(arr1, arr2));
        }

        static void getValues(int[,] arr, int n) // get user input for each value
        {
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    Console.WriteLine("Enter value for array #" + n + " row #" + a + " column #" + b);
                    arr[a, b] = int.Parse(Console.ReadLine()); // store input
                }
            }
            Console.Clear(); // fresh screen
        }

        static void printArray(int[,] arr) // prints array to screen
        {
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    Console.Write(arr[a, b] + " ");
                }
                Console.WriteLine(); // next line
            }
            Console.WriteLine(); /// spacing
        }

        static int[,] Addition (int[,] arr1, int[,] arr2) // adds two arrays together and returns as 2d array
        {
            int[,] arrAdded = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int a = 0; a < arrAdded.GetLength(0); a++) // row
            {
                for (int b = 0; b < arrAdded.GetLength(1); b++) // column
                {
                    arrAdded[a, b] = arr1[a, b] + arr2[a, b]; // adding both matrices
                }
            }
            return arrAdded;
        }
    }
}
