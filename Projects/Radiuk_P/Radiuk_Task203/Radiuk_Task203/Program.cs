using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task203
{
    class Program
    {
		public static void Main()
		{
			// Console.Write("\n");
			Console.WriteLine("Check whether a number is even or odd.");
			Console.WriteLine("---------------------------------------");
			Console.Write("Enter the number: ");
			int numberInput = Int32.Parse(Console.ReadLine());
			if (numberInput % 2 == 0)
				Console.WriteLine($"'{numberInput}' is an even number.");
			else
				Console.WriteLine($"'{numberInput}' is an odd number.");
			Console.ReadLine();
		}
	}
}
