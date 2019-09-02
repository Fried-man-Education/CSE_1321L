using System;

namespace Program3
{
	class Program
	{
		static void Main(string[] args)
		{
			float x1, y1, x2, y2;
			Console.Write("Entered X1: ");
			x1 = float.Parse(Console.ReadLine());
			Console.Write("Entered Y1: ");
			y1 = float.Parse(Console.ReadLine());
			Console.Write("Entered X2: ");
			x2 = float.Parse(Console.ReadLine());
			Console.Write("Entered Y2: ");
			y2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Distance: " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
		}
	}
}
