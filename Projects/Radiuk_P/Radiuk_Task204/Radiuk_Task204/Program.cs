using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task204
{
    class Program
    {
		public static void Main()
		{
			int numberInput, numberCount = 0, numberSum = 0;

			Console.Write("Enter a number between 1 and 100: ");
			numberInput = Int32.Parse(Console.ReadLine());

			if ((numberInput < 0) || (numberInput >= 100))
            {
                Console.WriteLine("Invalid input. Try again.");
			}
			else
            {
				// The sum and count of digits in the input number
				while ((numberInput > 0) && (numberInput < 100))
				{
					numberSum += numberInput % 10;
					numberInput /= 10;
					numberCount++;
				}
			}

			// The output result
			Console.WriteLine($"The number of digits is: {numberCount}.");
			Console.WriteLine($"The sum of digits is: {numberSum}.");
			Console.ReadLine();
		}
	}
}
