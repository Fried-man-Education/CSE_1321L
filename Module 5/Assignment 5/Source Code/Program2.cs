using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                Console.Write(convert(letter));
            }
        }

        public static string convert (char letter)
        {
            string[] conversion = new string[] {
                "4", "B", "(", "D", "3", "Ph",
                "9", "|-|", "1", "j", "|<", "L",
                "/\\/\\", "|\\|", "0", "P", "Q", "R",
                "$", "7", "U", "\\/", "\\/\\/", "><",
                "`/", "Z"
            };
            if ((int)letter > 96 && (int)letter < 123)
            {
                return conversion[(int)letter - 97];
            }else
            {
                return " ";
            }
        }
    }
}
