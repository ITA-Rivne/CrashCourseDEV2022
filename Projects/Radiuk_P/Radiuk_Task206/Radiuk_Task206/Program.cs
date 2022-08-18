using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task206
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberInput, numberSum = 0;

			Console.Write("Enter the number: ");
			numberInput = int.Parse(Console.ReadLine());

			while (numberInput > 0)
			{
				numberSum += numberInput % 10;
				numberInput /= 10;
			}

			Console.WriteLine($"The sum of number's digits is: {numberSum}.");
			Console.ReadLine();
		}
    }
}
