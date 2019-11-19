/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		14
*/

using System;

namespace SimpleSort
{
    class Program
    {
        static int comparisons;
        static void Main(string[] args)
        {
            // array setup
            int[] arr = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) // assign random values (1-100) for array
            {
                arr[i] = rnd.Next(1, 101);
            }
            int[] temp = new int[arr.Length]; // initialize
            // output data
            Console.Write("Arrays Values: ");
            printArray(arr);
            Console.WriteLine(); // end of values && spacing
            // bubble sort output
            copyArray(arr, temp);
            Console.Write("Bubble Sorted values: ");
            BubbleSort(temp);
            printArray(temp);
            Console.WriteLine("Bubble Sort Swaps: " + comparisons);
            Console.WriteLine(); // spacing
            // insertion sort output
            copyArray(arr, temp);
            Console.Write("Insertion Sorted values: ");
            InsertionSort(temp);
            printArray(temp);
            Console.WriteLine("Insertion Sort Swaps: " + comparisons);
            Console.WriteLine(); // spacing
            // selection sort ouput
            copyArray(arr, temp);
            Console.Write("Selection Sorted values: ");
            SelectionSort(temp);
            printArray(temp);
            Console.WriteLine("Selection Sort Swaps: " + comparisons);
        }
        
        static void printArray(int[] arr) // print each element in array
        {
            for (int i = 0; i < arr.Length; i++) // print array values
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) // if not last element
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); // end of list
        }

        static void copyArray (int[] original, int[] copy) // copies value by value to copy array
        {
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
        }

        static void BubbleSort(int[] arr) // sorts array via bubble sort
        {
            comparisons = 0;
            int temp;
            for (int a = 0; a <= arr.Length - 2; a++) // whole run by whole run
            {
                for (int b = 0; b <= arr.Length - 2; b++) // value by value
                {
                    comparisons++;
                    if (arr[b] > arr[b + 1]) // if larger swap
                    {
                        temp = arr[b + 1];
                        arr[b + 1] = arr[b];
                        arr[b] = temp;
                    }
                }
            }
        }
        static void InsertionSort(int[] arr) // sorts array via insertion sort
        {
            comparisons = 0;
            for (int index = 1; index < arr.Length; index++)
            {
                int key = arr[index];
                int pos = index;
                while (pos > 0 && key < arr[pos - 1]) //  Shift larger values to the right
                {
                    comparisons += 2;
                    arr[pos] = arr[pos - 1];
                    pos--;
                }
                arr[pos] = key;
            }
        }
        static void SelectionSort(int[] arr) // sorts array via selection sort
        {
            comparisons = 0;
            for (int a = 0; a < arr.Length - 1; a++)
            {
                int minPos = a;
                for (int b = a + 1; b < arr.Length; b++)
                {
                    comparisons++;
                    if (arr[b] < arr[minPos])
                        minPos = b;
                }
                comparisons += 2;
                if (a != minPos && minPos < arr.Length) // swap
                {
                    int temp = arr[minPos];
                    arr[minPos] = arr[a];
                    arr[a] = temp;
                }
            }

        }
    }
}
