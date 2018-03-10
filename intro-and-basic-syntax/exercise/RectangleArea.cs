using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// Receiving the two sides of the rectangle and parsing them to double
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
			
			// Calculating the area
            double ab = a * b;
			
			// Printing the area to the console
            Console.WriteLine($"{ab:F2}");
        }
    }
}
