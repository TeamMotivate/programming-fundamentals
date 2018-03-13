using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            // comment from Patronov
			// we receive from the console four integers on a single line.
			// we have to print them on the console in a creditcard format.
            var n1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", n1, num2, n3, n4);
        }
    }
}