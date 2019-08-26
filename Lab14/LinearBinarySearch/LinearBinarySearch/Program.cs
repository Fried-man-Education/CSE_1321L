/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		14
*/

using System;

namespace LinearBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Enter size of array:");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Value for element #" + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter target value: ");
            int target = int.Parse(Console.ReadLine());
            Console.Clear(); // fresh screen
            // output data
            Console.Write("Arrays Values: ");
            for (int i = 0; i < arr.Length; i++) // print array values
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) // if not last element
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); // end of line
            Console.WriteLine("Target value: " + target);
            Console.WriteLine(); // spacing
            Console.WriteLine("Linear Search Comparisons: " + linearSearch(arr, target));
            Console.WriteLine("Binary Search Comparisons: " + BinarySearch(arr, target));
        }

        static string linearSearch(int[] arr, int target)
        {
            int comparisons = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                comparisons++;
                if (target == arr[i]) // if target found
                {
                    return comparisons.ToString(); // return comparisons
                }
            }
            return "Target value doesnt exist"; // if target isnt in array
        }

        static string BinarySearch(int[] arr, int target)
        {
            int comparisons = 0;
            int low = 0, high = arr.Length - 1;
            while (low <= high) // while range exists
            {
                int mid = (low + high) / 2; // guess value
                comparisons++;
                if (target == arr[mid])
                {
                    return comparisons.ToString(); // if target found
                }
                else { // cut range in half
                    comparisons++;
                    if (target < arr[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            return "Target value doesnt exist"; // if target isnt in array
        }
    }
}
