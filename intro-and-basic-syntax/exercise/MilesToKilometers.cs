using System;

namespace p03_MilesToKilometers
{
    class P03
    {
        static void Main(string[] args)
        {
			//comment from nelkov
			//comment
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
