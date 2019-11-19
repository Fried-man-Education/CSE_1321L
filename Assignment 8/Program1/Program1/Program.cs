using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args) // such a neat main method
        {
            int[,] arrayA, arrayB;
            arrayA = new int[3, 3];
            arrayB = new int[3, 3];
            getInput(arrayA, 'A'); // get a
            getInput(arrayB, 'B'); // get b
            printArray(arrayA, 'A'); // print a
            printArray(arrayB, 'B'); // print b
            if (isEquivalent(arrayA, arrayB)) // check if arrays are equivalent
            {
                Console.WriteLine("Judgment: The arrays are equivalent.");
            }else
            {
                Console.WriteLine("Judgment: The arrays are not equivalent.");
            }
        }

        static void getInput(int[,] arrayX, char n) // get user input for array
        {
            for (int a = 0; a < arrayX.GetLength(0); a++) // row
            {
                for (int b = 0; b < arrayX.GetLength(1); b++) // column
                {
                    Console.WriteLine("Input row " + a + " column " + b + " value for Array " + n + ":");
                    arrayX[a, b] = int.Parse(Console.ReadLine()); // assign user value
                }
            }
            Console.Clear();
        }

        static void printArray(int[,] arrayX, char n) // print 2d array
        {
            Console.WriteLine("Array " + n + ":");
            for (int a = 0; a < arrayX.GetLength(0); a++) // row
            {
                for (int b = 0; b < arrayX.GetLength(1); b++) // column
                {
                    Console.Write(arrayX[a, b] + "  "); // print value and spacing
                }
                Console.WriteLine(); // new row
            }
        }

        static bool isEquivalent(int[,] arrayA, int[,] arrayB) // check if two arrays are the same
        {
            InsertionSort(arrayA); // sort arrayA
            InsertionSort(arrayB); // sort arrayB
            for (int a = 0; a < arrayA.GetLength(0); a++) // row
            {
                for (int b = 0; b < arrayA.GetLength(1); b++) // column
                {
                    if (arrayA[a, b] != arrayB[a, b]) // check if same positions have same values
                    {
                        return false; // values not same
                    }
                }
            }
            return true; // all values identical
        }

        static void InsertionSort(int[,] arrayX) // sorts array via insertion sort
        {
            for (int index = 1; index < arrayX.GetLength(0) * arrayX.GetLength(1); index++) // cycle 1 dimensionaly through 2d array 
            {
                int key = arrayX[index / arrayX.GetLength(0), index % arrayX.GetLength(1)];
                int pos = index;
                while (pos > 0 && key < arrayX[(pos - 1) / arrayX.GetLength(0), (pos - 1) % arrayX.GetLength(1)]) //  Shift larger values to the right
                {
                    arrayX[pos / arrayX.GetLength(0), pos % arrayX.GetLength(1)] = arrayX[(pos - 1) / arrayX.GetLength(0), (pos - 1) % arrayX.GetLength(1)]; // lets make this line longer lmao
                    pos--;
                }
                arrayX[pos / arrayX.GetLength(0), pos % arrayX.GetLength(1)] = key; // move value
            }
        }
    }
}
