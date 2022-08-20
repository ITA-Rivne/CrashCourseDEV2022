using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task208
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arrayInput = { -10, -9, 2, 1, -5, 0, 10, 7 };

			int index = 0;
			while (arrayInput[index] % 2 == 0)
			{
				index++;
			}

			int numberMinOdd = arrayInput[index];

			while (index < arrayInput.Length)
			{
				if (arrayInput[index] % 2 != 0)
				{
					if (arrayInput[index] < numberMinOdd)
					{
						numberMinOdd = arrayInput[index];
					}
				}
				index++;
			}

			Console.WriteLine("The smallest odd number is {0}.", numberMinOdd);
			Console.ReadLine();
		}
    }
}
