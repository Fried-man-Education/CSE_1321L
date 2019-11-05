using System;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {

            Random n = new Random();
            Span<char> DNA = stackalloc char[255];
            foreach (ref char letter in DNA)
            {
                switch(n.Next(4))
                {
                    case 0:
                        letter = 'G';
                        break;
                    case 1:
                        letter = 'C';
                        break;
                    case 2:
                        letter = 'A';
                        break;
                    case 3:
                        letter = 'T';
                        break;
                }
                Console.Write(letter);
            }
            Console.WriteLine();
            Console.WriteLine();
            ConvertAndPrint(DNA);
        }

        static void ConvertAndPrint (Span<char> input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'T')
                {
                    input[i] = 'U';
                }
                Console.Write(input[i]);
            }
        }
    }
}
