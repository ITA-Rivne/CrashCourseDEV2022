using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task205
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberInput, numberReversed = 0;

			Console.Write("Enter the number: ");
			numberInput = Int32.Parse(Console.ReadLine());

			while (numberInput != 0)
			{
				numberReversed = (numberReversed * 10) + (numberInput % 10);
				numberInput /= 10;
			}

			Console.WriteLine("The reversed number is {0}.", numberReversed);
			Console.ReadLine();
		}
    }
}
