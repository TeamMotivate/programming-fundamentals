using System;

namespace p03_MilesToKilometers
{
    class P03
    {
        static void Main(string[] args)
        {
			//comment from nelkov
			//comment
			//comment 2
			// Georgi Patronov chnaged variables in code;
			//VariablesChanged=>kilometers
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
