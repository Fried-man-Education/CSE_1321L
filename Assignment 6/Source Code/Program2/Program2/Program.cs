using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Color tv = new Color(254, 2, 100);
            while (true)
            {
                tv.toString();
                Console.WriteLine(
                    "Do you want to: 1) Increase Red, 2) Decrease Red \n" +
                    "3) Increase Green, 4) Decrease Green \n" +
                    "5) Increase Blue, 6) Decrease Blue \n" +
                    "7) Print the inverse\n" +
                    " or 8) Quit"
                );
                switch (Console.ReadLine())
                {
                    case "1":
                        tv.incR();
                        break;
                    case "2":
                        tv.decR();
                        break;
                    case "3":
                        tv.incG();
                        break;
                    case "4":
                        tv.decG();
                        break;
                    case "5":
                        tv.incB();
                        break;
                    case "6":
                        tv.decB();
                        break;
                    case "7":
                        tv.inverse();
                        break;
                    case "8":
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("invalid input...");
                        break;
                }
            }
        }

        class Color
        {
            int r, g, b;
            float l;
            public Color(int newR, int newG, int newB)
            {
                r = newR;
                g = newG;
                b = newB;
            }
            public void incR() => r += 1 - (r / 255);
            public void decR() => r -= 1 - (1 / (r + 1));
            public void incG() => g += 1 - (g / 255);
            public void decG() => g -= 1 - (1 / (g + 1));
            public void incB() => b += 1 - (b / 255);
            public void decB() => b -= 1 - (1 / (b + 1));
            public void inverse() => Console.WriteLine("Inverse is R:" + (255 - r) + " G:" + (255 - g) + " B:" + (255 - b));
            public void toString()
            {
                l = 0.2126f * r + 0.7152f * g + 0.0722f * b;
                Console.WriteLine("R:" + r + " G:" + g + " B:" + b + " L:" + l);
            }
        }
    }
}
