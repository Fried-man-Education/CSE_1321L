using System;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Random n = new Random();
            for (int i = 0; i < numbers.Length; i++) // assign random values (1-50)
            {
                numbers[i] = n.Next(1, 51);
            }
            printArray(numbers); // init print
            while (!sortedCheck(numbers)) // while array not sorted
            {
                numbers = shuffleArray(numbers); // shuffle array and assign to original
                printArray(numbers); // print new array
            }
        }

        static void printArray(int[] numbers) // print out array in single line
        {
            Console.Write("|"); // far left border
            for (int i = 0; i < numbers.Length; i++) // prints each value
            {
                Console.Write(numbers[i] + "|");
            }
            Console.WriteLine(); // far right border
        }

        static int[] shuffleArray(int[] numbers) // shuffles array randomly
        {
            int[] newNumbers = new int[numbers.Length]; // new array
            Random n = new Random();
            for (int i = 0; i < numbers.Length; i++) // cycle through each value
            {
                int temp = n.Next(numbers.Length); // choose new positon of numbers[i]
                while (newNumbers[temp] != 0) // ensure no duplicates
                {
                    temp = n.Next(numbers.Length); // pick new spot
                }
                newNumbers[temp] = numbers[i]; // assign i value to new spot
            }
            return newNumbers;
        }

        static bool sortedCheck(int[] numbers) // check if array sorted
        {

            for (int i = 0; i < numbers.Length; i++) // cycle through each value
            {
                if (i + 1 == numbers.Length) // made it to end of array with no breaks
                {
                    return true; // sorted
                }else if (numbers[i] > numbers[i + 1]) // check if i is greater than its neighbor to right
                {
                    break;
                }
            }
            return false; // not sorted
        }
    }
}
