/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		13
*/

using System;

namespace SumArrayColumns
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
                    Console.WriteLine("Enter value for row #" + a + " column #" + b);
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
            int[] columnSum = sumColumn(arr); // get sum of columns in array
            for (int i = 0; i < columnSum.Length; i++) // column
            {
                Console.WriteLine("Sum of column " + i + " is " + columnSum[i]);
            }
        }

        static int[] sumColumn(int[,] arr) // return sum of columns for input array
        {
            int[] columnSum = new int[arr.GetLength(1)]; // storage
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    columnSum[b] += arr[a, b];
                }
            }
            return columnSum;
        }
    }
}
