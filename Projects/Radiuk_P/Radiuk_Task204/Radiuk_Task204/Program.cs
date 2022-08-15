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

			Console.Write("Enter the number: ");
			numberInput = Int32.Parse(Console.ReadLine());

			while (numberInput > 0 && numberInput < 100)
			{
				numberSum += numberInput % 10;
				numberInput /= 10;
				numberCount++;
			}

			Console.WriteLine("The number of digits is: {0}.", numberCount);
			Console.WriteLine("The sum of digits is: {0}.", numberSum);
			Console.ReadLine();
		}
	}
}
