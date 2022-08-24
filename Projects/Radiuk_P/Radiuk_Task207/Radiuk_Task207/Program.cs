using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task207
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arrayInput = {1000, 1, 1, 1, 2, 2, -3, 0, 9, -10, 11, 8, 9};

			var myDictionary = new Dictionary<int, int>();

			foreach (var res in arrayInput)
			{
				if (myDictionary.ContainsKey(res))
				{
					myDictionary[res]++;
				}
				else
				{
					myDictionary[res] = 1;
				}
			}

			foreach (var valueTemp in myDictionary)
			{
				if (valueTemp.Value > 1)
				{
					Console.WriteLine($"Duplicate {valueTemp.Key} occured {valueTemp.Value} times.");
				}
			}
			Console.ReadLine();
		}
    }
}
