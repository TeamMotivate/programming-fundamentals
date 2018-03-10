using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// Receiving the two sides of the rectangle and parsing them to double
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
			
			// Calculating the area
            double area = sideA * sideB;
			
			// Printing the area to the console
            Console.WriteLine($"{area:F2}");
        }
    }
}
