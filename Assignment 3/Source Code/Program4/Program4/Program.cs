using System;

namespace Program4
{
    class Program
    {
        static int sallary;
        static void Main(string[] args)
        {
            Console.Write("Enter your salary to the nearest dollar: ");
            sallary = int.Parse(Console.ReadLine());
            float tax = 0;
            tax += taxAdder(9525, 0, .1f);
            tax += taxAdder(38700, 9525, .12f);
            tax += taxAdder(82500, 38700, .22f);
            tax += taxAdder(157500, 82500, .24f);
            tax += taxAdder(200000, 157500, .32f);
            tax += taxAdder(500000, 200000, .35f);
            tax += taxAdder(0, 500000, .37f);
            Console.Write("Total tax owed is: $" + tax);
        }

        static float taxAdder (int amount, int previous, float rate)
        {
            if (sallary > amount - previous && amount != 0)
            {
                sallary -= amount - previous;
                return (amount - previous) * rate;
            }else
            {
                int temp = (int)(sallary * rate);
                sallary = 0;
                return temp;
            }
        }
    }
}
