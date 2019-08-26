/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		13
*/

using System;

namespace LocateLargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]; // initialize 2d array 3 x 4
            // get user input for each value
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    Console.WriteLine("Enter value for array #" + a + " value #" + b);
                    arr[a, b] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear(); // fresh screen
            // output
            Console.WriteLine("The entered martix:");
            // print array
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    Console.Write(arr[a, b] + " ");
                }
                Console.WriteLine(); // next line
            }
            Console.WriteLine(); /// spacing
            int[] cord = locateLargest(arr); // calculate and store coordinates
            Console.WriteLine("First largest value is located at row " + cord[0] + " and column " + cord[1]);
        }

        static int[] locateLargest (int[,] arr) // find first max value in 2d array
        {
            int[] cord = new int[2]; // coordinate storage
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    if (arr[a, b] > arr[cord[0], cord[1]]) // if new max
                    {
                        cord[0] = a; // x-coordinate
                        cord[1] = b; // y-coordinate
                    }
                }
            }
            return cord;
        }
    }
}
